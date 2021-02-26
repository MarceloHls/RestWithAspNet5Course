using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            //_logger = logger;
        }

        [HttpGet("simples/{operation}/{firstNumber}/{secondNumber}")]
        public IActionResult Somar(string operation,string firstNumber,string secondNumber)
        {
            decimal sum = 0;
            if (isNumeric (firstNumber) && isNumeric(secondNumber))
            {
                if (operation.Equals("somar")){
                    sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                }else if (operation.Equals("subtrair"))
                {
                    sum = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                }
                else if (operation.Equals("multiplicar"))
                {
                    sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                }
                else if (operation.Equals("dividir"))
                {
                    sum = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                }

                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }
        [HttpGet("media/{numbers}")]
        
        public IActionResult Media(string numbers)
        {
            string[] numbersArray = numbers.Split("-");
            decimal total = 0;

            foreach(string numberString in numbersArray)
            {
                if (isNumeric(numberString))
                {
                    total+= decimal.Parse(numberString);
                }
                else
                {
                    return BadRequest("Invalid Input");
                }
            }
            decimal media = total / numbersArray.Length;
           

            return Ok(media.ToString());
        }

        [HttpGet("raiz/{number}")]
        public IActionResult RaizQudrada(string number)
        {
            if (isNumeric(number))
            {
                var raiz = Math.Sqrt(double.Parse(number));
                return Ok(raiz.ToString());
            }
            return BadRequest("Invalid Input");
        }


        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
           if (decimal.TryParse(strNumber,out decimalValue)) { return decimalValue; }
            return 0;
        }

        private bool isNumeric(string strNumber)
        {
            return double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out double number
                );
        }
    }
}
