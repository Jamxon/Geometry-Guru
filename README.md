# Geometry Guru

**Geometry Guru** — bu interaktiv C# konsol dasturi bo‘lib, foydalanuvchilarga turli geometrik shakllarning yuzasini hisoblash imkonini beradi. Dastur konsol menyusi orqali ishlaydi va **doira, uchburchak, to‘rtburchak va parallelogram** yuzalarini hisoblay oladi.

---

## 🎬 GIF

![Geometry Guru Demo]([https://media.giphy.com/media/3o6Zt481isNVuQI1l6/giphy.gif](https://private-user-images.githubusercontent.com/74038190/240906093-9be4d344-6782-461a-b5a6-32a07bf7b34e.gif?jwt=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NjUyNzk2NjIsIm5iZiI6MTc2NTI3OTM2MiwicGF0aCI6Ii83NDAzODE5MC8yNDA5MDYwOTMtOWJlNGQzNDQtNjc4Mi00NjFhLWI1YTYtMzJhMDdiZjdiMzRlLmdpZj9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNTEyMDklMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjUxMjA5VDExMjI0MlomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPWU3ZjY5ZjkzOWRkN2MzYWFmMTM1NzkyYzk0NDg4MGI5MzRmMmU3YTRkOGRkOTJhYThhMDcxODc0MmFkYzY1MDAmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.lRKC02sM3otfqpwDHybljPqxXKRF2KGR0Q6dmLmVSwU))  
*GIFda dastur ishga tushishi va menyu ishlashini ko‘rish mumkin.*

---

## 📌 Xususiyatlar

- 🔘 **Doira** yuzasini hisoblash (`Circle`)  
- 🔺 **Uchburchak** yuzasini hisoblash (`Triangle`)  
  - 2 tomon berilganda uchinchi tomon oralig‘ini ko‘rsatish  
  - 3 tomon berilganda haqiqiy yuzani hisoblash  
- ▭ **To‘rtburchak** yuzasini hisoblash (`Rectangle`)  
- ⬛ **Parallelogram** yuzasini hisoblash (`Parallelogram`)  
- Foydalanuvchi bilan **interaktiv menyu**  
- Konsolga **ASCII menyu dizayni**

---

## 🖥️ Ishlatish

1. Dastur ishga tushirilganda menyu paydo bo‘ladi:

╔═══════════════════════╗
║ Geometry Guru ║
╠═══════════════════════╣
║ 1. 🔘 Doira ║
║ 2. 🔺 Uchburchak ║
║ 3. ▭ To‘rtburchak ║
║ 4. ⬛ Parallelogram ║
║ 0. ❌ Chiqish ║
╚═══════════════════════╝

yaml
Copy code

2. Tanlovni raqam bilan kiriting va dastur sizdan kerakli o‘lchamlarni so‘raydi.  
3. Hisoblangan yuzalar konsolga chiqariladi.  
4. Dastur tugashidan oldin sizga **qayta ishlashni xohlaysizmi? (y/n)** deb so‘raydi.

---

## 🔧 Misol ishlatish

### 1️⃣ Doira

```csharp
// Doira yuzasini hisoblash
public void Circle(int radius)
{
    double area = radius * radius * Math.PI;
    Console.WriteLine($"Doira yuzasi: {radius} * {radius} * π = {area:F2}");
}
Konsol output:

yaml
Copy code
Tanlovingiz: 1
Doira radiusini kiriting: 5
Doira yuzasi: 78.54
2️⃣ Uchburchak
csharp
Copy code
// 3 tomon berilganda yuzani hisoblash
public void Triangle(int a, int b, int c)
{
    if (!(a + b > c && a + c > b && b + c > a))
    {
        Console.WriteLine("Uchburchak bo‘la olmaydi!");
        return;
    }

    double p = (a + b + c) / 2.0;
    double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    Console.WriteLine($"Uchburchak yuzasi: {area:F2}");
}
Konsol output:

yaml
Copy code
Tanlovingiz: 2
Uchburchakda nechta tomon kiritasiz? (2 yoki 3): 3
Birinchi tomon: 3
Ikkinchi tomon: 4
Uchinchi tomon: 5
Uchburchak yuzasi: 6.00
2 tomon berilganda uchinchi tomon oralig‘ini ko‘rsatish funksiyasi ham mavjud.

