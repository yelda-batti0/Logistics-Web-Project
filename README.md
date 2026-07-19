# Transp — Dynamic Logistics Company Website & Admin Panel

> 🚧 **Status: In active development** — core features are complete, shipment tracking and price calculation backend are in progress.

A fully dynamic, content-manageable corporate website built for a logistics company with **ASP.NET Core**. The entire public-facing site is powered by a custom admin panel (**Silva**), meaning every section — sliders, services, brands, corporate content, project portfolio, testimonials and FAQs — can be created, edited and managed without touching a single line of code.

---

## ✨ Features

### 🌐 Public Website (Transp)
- **Fully dynamic content** — every section of the site is fed from the database and managed via the admin panel
- **Multi-language support** — Turkish / English language switching
- **Hero slider** with manageable slides
- **Services section** — air, road, rail, sea, international freight and warehousing & distribution
- **"How It Works" process section** — step-by-step visual flow of the logistics process
- **Project portfolio** — showcase of completed logistics projects
- **Partner brands** section with logo management
- **Customer testimonials** and **FAQ** sections
- **Price calculation form** — service type, dimensions, weight, origin/destination, cargo type, quantity and optional add-ons (express delivery, cargo insurance, packaging)
- **Contact form** ("Bize Yazın")
- **User login** and **shipment tracking** entry points
- Responsive, modern UI

### 🛠️ Admin Panel (Silva)
- **Dashboard-style management screens** with live statistics (total records, active/passive counts, view counts, monthly additions)
- **Slider Management** — create, edit, delete and activate/deactivate hero slides
- **Brand Management** — manage partner brand logos with active/passive states
- **Service Management** — full CRUD for logistics services with descriptions and view statistics
- **Corporate Content Management** — manage "About Us" and company story content with reading-rate analytics
- **"What We Do" & "How It Works" Management** — edit process steps shown on the homepage
- **Customer Testimonials Management**
- **Project Portfolio Management** — add and manage completed projects with images
- **FAQ Management**
- **Search, filtering (All / Active / Passive), pagination and grid/list view toggles** across management screens

---

## 🖼️ Screenshots

| Public Site | Admin Panel |
|---|---|
| ![Homepage](docs/screenshots/homepage.png) | ![Slider Management](docs/screenshots/admin-slider.png) |
| ![Price Calculation](docs/screenshots/price-calculation.png) | ![Brand Management](docs/screenshots/admin-brands.png) |
| ![How It Works](docs/screenshots/how-it-works.png) | ![Service Management](docs/screenshots/admin-services.png) |

> 📌 More screenshots available in the [`docs/screenshots`](docs/screenshots) folder.

---

## 🧰 Tech Stack

| Layer | Technology |
|---|---|
| Backend | ASP.NET Core [sürüm — ör. 8.0] (MVC) |
| ORM | Entity Framework Core |
| Database | [SQL Server / PostgreSQL / MySQL] |
| Authentication | [ASP.NET Core Identity / Cookie Authentication] |
| Frontend | HTML5, CSS3, JavaScript, Bootstrap |
| Architecture | [Katmanlı mimari / MVC — kullandığın yapıyı yaz] |

---

## 🗺️ Roadmap

- [x] Dynamic homepage with admin-managed sections
- [x] Admin panel with full CRUD for all content types
- [x] Multi-language support (TR / EN)
- [x] Price calculation form (UI)
- [ ] **Shipment tracking system** — real-time cargo status tracking
- [ ] **Price calculation backend** — dynamic pricing engine based on service, route, weight and add-ons
- [ ] Contact form submissions management in admin panel
- [ ] Deployment & production release

---

## 🚀 Getting Started

```bash
# Clone the repository
git clone https://github.com/[kullanici-adin]/[repo-adi].git

# Navigate into the project
cd [repo-adi]

# Restore dependencies
dotnet restore

# Apply database migrations
dotnet ef database update

# Run the application
dotnet run
```

The site will be available at `https://localhost:[port]` and the admin panel at `/[admin-route]`.

---

## 📬 Contact

**[Adın Soyadın]**
- GitHub: [github.com/kullanici-adin](https://github.com/kullanici-adin)
- LinkedIn: [linkedin.com/in/profilin](https://linkedin.com/in/profilin)

---

*This project is under active development — new features are being added regularly.*
