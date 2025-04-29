using Microsoft.AspNetCore.Mvc;
using tpmodul9_NIM.Models;

namespace tpmodul9_NIM.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "GANES GEMI PUTRA", Nim = "2311104075" },
            new Mahasiswa { Nama = "Ryan Gabriel Togar Simamora", Nim = "2311104045" },
            new Mahasiswa { Nama = "Reza afiansyah Wibowo", Nim = "2311104062" }
        };

        [HttpGet]
        public ActionResult<List<Mahasiswa>> GetAll() => daftarMahasiswa;

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
            return daftarMahasiswa[index];
        }

        [HttpPost]
        public IActionResult Post([FromBody] Mahasiswa mahasiswa)
        {
            daftarMahasiswa.Add(mahasiswa);
            return CreatedAtAction(nameof(Get), new { index = daftarMahasiswa.Count - 1 }, mahasiswa);
        }

        [HttpDelete("{index}")]
        public IActionResult Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
            daftarMahasiswa.RemoveAt(index);
            return NoContent();
        }
    }
}
