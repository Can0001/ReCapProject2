using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CardManager : ICardService
    {
        private ICardDal _cardDal;

        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }


        public IResult Add(Card card)
        {
            var result=BusinessRules.Run(CheckIsCreditCardExist(card.CardNumber));
            if (result==null)
            {
                return new ErrorResult();
            }
            _cardDal.Add(card);
            return new SuccessResult();
        }

        public IResult Delete(Card card)
        {
            _cardDal.Delete(card);
            return new SuccessResult();
        }

        public IDataResult<List<Card>> GetAll()
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll());
        }

        public IDataResult<Card> GetById(int cardId)
        {
            return new SuccessDataResult<Card>(_cardDal.Get(c => c.CardId == cardId));
        }

        public IDataResult<List<Card>> GetCardsByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll(c => c.CustomerId == customerId));
        }

        public IResult Update(Card card)
        {
            _cardDal.Update(card);
            return new SuccessResult();
        }

        private IResult CheckIsCreditCardExist(string cardNumber)
        {
            if (!_cardDal.Any(x => x.CardNumber == cardNumber))
            {
                return new ErrorResult("Kredi Kartı Mevcut");
            }
            return new SuccessResult();
        }
    }
}
