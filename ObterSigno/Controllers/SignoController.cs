using Microsoft.AspNetCore.Mvc;

namespace ObterSigno.Controllers;
public class SignoController : Controller
{
    [HttpGet("GetSign")]
    public void GetSign(int day, int month)
    {
        DateTime birthDate = new(DateTime.Now.Year, month, day);

        CheckSign(birthDate);
    }

    public string CheckSign(DateTime dayBirth)
    {
        string s = dayBirth.Month switch
        {
            1 => (dayBirth.Day <= 20) ? "Capricórnio" : "Aquário", // Janeiro
            2 => (dayBirth.Day <= 19) ? "Aquário" : "Peixes", // Fevereiro
            3 => (dayBirth.Day <= 20) ? "Peixes" : "Áries", // Março
            4 => (dayBirth.Day <= 20) ? "Áries" : "Touro", // Abril
            5 => (dayBirth.Day <= 21) ? "Touro" : "Gêmeos", // Maio
            6 => (dayBirth.Day <= 21) ? "Gêmeos" : "Câncer", // Junho
            7 => (dayBirth.Day <= 22) ? "Câncer" : "Leão", // Julho
            8 => (dayBirth.Day <= 22) ? "Leão" : "Virgem", // Agosto
            9 => (dayBirth.Day <= 22) ? "Virgem" : "Libra", // Setembro
            10 => (dayBirth.Day <= 22) ? "Libra" : "Escorpião", // Outubro
            11 => (dayBirth.Day <= 21) ? "Escorpião" : "Sagitário", // Novembro
            12 => (dayBirth.Day <= 21) ? "Sagitário" : "Capricórnio", // Dezembro
            _ => "Data inválida",
        };

        return s;
    }
}
