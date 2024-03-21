using System;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Globalization;

namespace Athena.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet("api/Book/GetPow")]
        public async Task<IActionResult> GetPow(int number)
        {
            return Ok("El resultado es: " + (Math.Pow(number, 3)));
        }

        [HttpGet("api/Book/GetISODate")]
        public async Task<IActionResult> GetISODate()
        {
            return Ok(DateTime.UtcNow.ToString("yyyy-mm-dd"));
        }

        [HttpGet("api/Book/GetDateMessage")]
        public async Task<IActionResult> GetDateMessage()
        {
            DateTime date = DateTime.Now;
            CultureInfo culture = CultureInfo.CurrentCulture;
            int weekNumber = culture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday); 

            return Ok("Today is " + date.DayOfWeek + " " + date.Day + " of " + date.ToString("MMMM") + ", " + date.Year + ". We are in the:  " + weekNumber + " week of the year. And it's " + date.ToString("HH:mm:ss")
            );
        }
    }

    //Crear un método Get que me devuelva la fecha en ISO.
    //Crear un método Get que me devuelva: Hoy es martes 12 de marzo de 2024, la semana número 12 del año. Son las 6.50 de la tarde (18:50 en horario de 24 horas).
    //Crear un método Post que reciba una clase que tiene Nombre y Apellido, y la fecha de nacimiento. calcular cuántos años tiene la persona, llamándola de la siguiente forma:
    // "Camila tiene 42 años"...
}