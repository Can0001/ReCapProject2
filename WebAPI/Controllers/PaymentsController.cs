using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        IPaymentService _paymentsService;
        public PaymentsController(IPaymentService paymentService)
        {
            _paymentsService=paymentService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _paymentsService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbypaymentid")]
        public IActionResult GetByPaymentId(int paymentId)
        {
            var result = _paymentsService.GetById(paymentId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //post-add,update ,delete
        [HttpPost("add")]
        public IActionResult Add(Payment payment)
        {
            var result = _paymentsService.Add(payment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Payment payment)
        {
            var result = _paymentsService.Update(payment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Payment payment)
        {
            var result = _paymentsService.Delete(payment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
