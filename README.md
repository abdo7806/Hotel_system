---

# 🏨 Hotel Management System | نظام إدارة الفنادق

A desktop application built with Three-Tier Architecture to manage hotel operations including room management, guest management, bookings, invoices, payments, and reports. Supports role-based permissions for Admin and User.

نظام ديسك توب مبني على الهندسة المعمارية الثلاثية (Three-Tier Architecture) لإدارة عمليات الفندق مثل إدارة الغرف، النزلاء، الحجوزات، الفواتير، المدفوعات، وإنشاء التقارير، مع دعم صلاحيات المستخدم والمشرف.

---

## 🔧 Technologies Used | التقنيات المستخدمة

### 🖥 Backend:

* C# WinForms (Desktop Application)
* SQL Server (Database)
* T-SQL (Stored Procedures, Queries)
* Three-Tier Architecture (Presentation, Business Logic, Data Access Layers)
* Role-Based Authorization (Admin, User)

---

## 👥 User Roles | صلاحيات المستخدمين

### 👤 User | المستخدم:

* View rooms and their status | عرض الغرف وحالاتها
* Manage personal bookings | إدارة الحجوزات الخاصة
* View invoices and payments | عرض الفواتير والمدفوعات

### 🛠 Admin | المشرف:

* Full CRUD on rooms, guests, bookings, invoices, payments | إدارة كاملة للغرف، النزلاء، الحجوزات، الفواتير، والمدفوعات
* Generate and view reports | إنشاء وعرض التقارير
* Manage users and roles | إدارة المستخدمين والصلاحيات

---

## 📁 Project Structure | هيكل المشروع
```
Hotel_System/
├── Presentation/                 # واجهة المستخدم (WinForms)
│   ├── Forms/                   # النماذج (Forms)
│
├── BusinessLogic/               # طبقة منطق الأعمال
│
├── DataAccess/                 # طبقة الوصول للبيانات
│
├── SQL_Scripts/                # استعلامات T-SQL والإجراءات المخزنة  
└── README.md                   # ملف التوثيق
```
## 🚀 How to Run | كيفية التشغيل

1. Configure SQL Server database with the provided SQL scripts | إعداد قاعدة البيانات باستخدام الاستعلامات والإجراءات المخزنة
2. Open the solution in Visual Studio | افتح المشروع في Visual Studio
3. Build and run the WinForms application | بناء وتشغيل تطبيق سطح المكتب
4. Login as Admin or User | تسجيل الدخول كمشرف أو مستخدم
5. Start managing hotel operations | ابدأ بإدارة عمليات الفندق

---

## 🌟 Features | المميزات

* Role-based authorization (Admin/User) | صلاحيات مبنية على الدور (مشرف/مستخدم)
* Full CRUD operations on rooms, guests, bookings, invoices, and payments | عمليات إنشاء، قراءة، تحديث، وحذف كاملة
* Room status tracking (available, occupied, reserved) | تتبع حالة الغرف (متاحة، مشغولة، محجوزة)
* Booking management with date filtering | إدارة الحجوزات مع فلترة بالتواريخ
* Invoice generation and payment tracking | إنشاء الفواتير وتتبع المدفوعات
* Dynamic report generation | إنشاء تقارير ديناميكية
* Clean separation of concerns using Three-Tier Architecture | فصل واضح بين الطبقات الثلاث (عرض، منطق، بيانات)
* Use of T-SQL stored procedures for optimized database operations | استخدام إجراءات مخزنة T-SQL لتحسين الأداء

---

## 📸 Screenshots | لقطات شاشة

### 🟢 Login Form
![Login Form](https://github.com/abdo7806/Hotel_system/blob/master/LoginForm.png?raw=true)

### 🟢 Admin Dashboard
![Admin Dashboard](https://github.com/abdo7806/Hotel_system/blob/master/AdminDashboard.png?raw=true)

### 🟢 Room Management
![Rooms Form](https://github.com/abdo7806/Hotel_system/blob/master/RoomsForm.png?raw=true)

### 🟢 Guest Management
![Guests Form](https://github.com/abdo7806/Hotel_system/blob/master/GuestsForm2.png?raw=true)

### 🟢 Booking Management
![Bookings Form](https://github.com/abdo7806/Hotel_system/blob/master/ManageReservationsForm.png?raw=true)

### 🟢 Show Booking Management
![Bookings Form](https://github.com/abdo7806/Hotel_system/blob/master/ShowBookingsForm.png?raw=true)

### 🟢 Add Booking Management
![Bookings Form](https://github.com/abdo7806/Hotel_system/blob/master/AddBookingsForm.png?raw=true)

### 🟢 Invoice Management
![Invoices Form](https://github.com/abdo7806/Hotel_system/blob/master/InvoicesForm.png?raw=true)

### 🟢 Payment Management
![Payments Form](https://github.com/abdo7806/Hotel_system/blob/master/PaymentsForm.png?raw=true)

### 🟢 Reports Generation
![Reports Form](https://github.com/abdo7806/Hotel_system/blob/master/ReportsForm.png?raw=true)

### 🟢 User Interface (Optional)
![User View](https://github.com/abdo7806/Hotel_system/blob/master/UserView.png?raw=true)

---

## 👨‍💻 Developer | المطور

### 🙋‍♂️ About the Developer

I'm **Abdulsalam Dhahabi**, a passionate software developer with strong experience in desktop and web applications.

* C# WinForms & ASP.NET Core
* SQL Server & T-SQL
* Clean Architecture & Design Patterns
* Git & GitHub (2000+ problems solved)

🔗 GitHub: [github.com/abdo7806](https://github.com/abdo7806)
📧 Email: [balzhaby26@gmail.com](mailto:balzhaby26@gmail.com)
🌍 LinkedIn: [linkedin.com/in/abdulsalam-al-dhahabi-218887312](https://linkedin.com/in/abdulsalam-al-dhahabi-218887312)

---

## 🤝 Contributing | المساهمة

Contributions and feedback are welcome!
Feel free to open issues or submit pull requests.

---

## 📃 License | الترخيص

This project is open-source for learning and personal use only.  
هذا المشروع مفتوح المصدر لأغراض التعلم والاستخدام الشخصي فقط.
---
