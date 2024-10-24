# 📝 سیستم آزمون آنلاین  

پروژه‌ای برای برگزاری آزمون‌های آنلاین ویژه دانشجویان و اساتید، ساخته شده با **ASP.NET Core 8**، **Razor Pages**، **Entity Framework Core** و **SQL Server**. دانشجویان با کد ملی وارد شده و می‌توانند در آزمون‌های اختصاص داده شده به کلاس‌های خود شرکت کنند. اساتید نیز می‌توانند سوالات طراحی کرده و آزمون‌ها را مدیریت کنند.

---

## 🚀 ویژگی‌ها  
 **صفحه ورود :**  
   - ورود با کد ملی و رمز عبور  
   - دسترسی‌های مختلف بر اساس نقش (دانشجو یا استاد)  

 **داشبورد دانشجو:**  
   - نمایش لیست آزمون‌های کلاس‌های ثبت‌نام‌شده  
   - امکان شرکت در آزمون در زمان تعیین‌شده  
   - نمایش وضعیت آزمون (باز یا بسته بودن)  

 **داشبورد استاد:**  
   - امکان طراحی سوالات جدید  
   - اختصاص آزمون به کلاس‌ها  
   - مشاهده و مدیریت نتایج آزمون‌ها  

 **مدیریت کلاس‌ها و آزمون‌ها:**  
   - ارتباط **چند-به-چند** بین کلاس‌ها و آزمون‌ها  
   - مشاهده لیست دانشجویان ثبت‌نام‌شده در هر کلاس  



---

## 🛠 مدل‌های دیتابیس  
- **Users:** نگهداری اطلاعات کاربران (دانشجو یا استاد)  
- **Exams:** مشخصات آزمون‌ها (عنوان، زمان شروع و پایان)  
- **Questions:** سوالات هر آزمون  
- **Classes:** مدیریت کلاس‌ها  
- **StudentClasses:** ارتباط چند-به-چند بین دانشجویان و کلاس‌ها  
- **ExamClasses:** ارتباط چند-به-چند بین آزمون‌ها و کلاس‌ها  

---

## 🛠 تکنولوژی‌های استفاده شده  
- **ASP.NET Core 8**  
- **Razor Pages**  
- **Entity Framework Core**  
- **SQL Server**  

---

## ⚙ پیش‌نیازها  
- **ASP.NET Core SDK**  
- **ASP.NET Core Runtime**

---

## 🔧 نصب و راه‌اندازی  

1. کلون کردن ریپوزیتوری:  
   ```bash
   git clone https://github.com/Rezacj/Danesh_Azmon.git
   
   ```
   ```bash
   cd Danesh_Azmon
   ```
2. اعمال مایگریشن:  
   ```bash
   dotnet ef database update
   ```
3. اجرای برنامه:  
   ```bash
   dotnet run
   ```
