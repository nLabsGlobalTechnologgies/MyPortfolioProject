let apiUrl = "https://localhost:7135/api/";
let controller = apiUrl + "Home/";

let skills = controller + "GetSkills";
let services = controller + "GetServices";
let educations = controller + "GetEducations";
let experiences = controller + "GetExperiences";
let projects = controller + "GetProjects";
let settings = controller + "GetSettings/id?id=1";


async function getEducations() {
    var res = await fetch(educations).then(res => res.json());

    let text = "";
    const el = document.getElementById("educations");
    for (let s of res) {
        text += `
            <div class="timeline-item">
                <div class="circle-dot"></div>
                <h3 class="timeline-date">
                    <i class="fa fa-calendar"></i> ${s.startMonth} - ${s.startYear}
                </h3>
                <h3 class="timeline-title">${s.name}</h3>
                <p class="timeline-text">
                    ${s.description}
                </p>
            </div>
        `;
    }
    el.innerHTML = text;
}

getEducations();

async function getExperiences() {
    var res = await fetch(experiences).then(res => res.json());

    let text = "";
    const el = document.getElementById("experiences");

    for (let e of res) {
        text += `
            <div class="timeline-item">
                <div class="circle-dot"></div>
                <h3 class="timeline-date">
                    <i class="fa fa-calendar"></i> ${e.startMonth}.${e.startYear} - ${e.endMonth}.${e.endYear}
                </h3>
                <h3 class="timeline-title">${e.name}</h3>
                <p class="timeline-text">
                    ${e.description}
                </p>
            </div>
        `;
    }
    el.innerHTML = text;
}

getExperiences();

async function getServices() {
    var res = await fetch(services).then(res => res.json());

    let text = "";
    const el = document.getElementById("services");
    for (let s of res) {
        text += `
            <div class="service-item pad-15">
                <div class="service-item-inner">
                    <div class="icon">
                        <i class="fa fa-${s.icon}"></i>
                    </div>
                    <h4>${s.name}</h4>
                    <p>${s.description}</p>
                </div>
            </div>
        `;
    }
    el.innerHTML = text;
}

getServices();

async function getSkills() {
    var res = await fetch(skills).then(res => res.json());

    let text = "";
    const el = document.getElementById("skills");
    for (let s of res) {
        text += `
            <div class="skill-item padd-15">
                <h5>${s.name}</h5>
                <div class="progress">
                    <div class="progress-in" style="width: ${s.rating}%;"></div>
                    <div class="skill-percent">${s.rating}%</div>
                </div>
            </div>
        `;
    }
    el.innerHTML = text;
}

getSkills();

async function getProjects() {
    var res = await fetch(projects).then(res => res.json());

    let text = "";
    const el = document.getElementById("portfolios");

    for (let p of res) {
        text += `
            <div class="portfolio-item padd-15">
                <div class="portfolio-item-inner shadow-dark">
                    <div class="portfolio-img">
                        <img src="assets/images/portfolio/${p.imageUrl}" alt="${p.name}">
                    </div>
                </div>
            </div>
        `;
    }

    el.innerHTML = text;
}

getProjects();

async function getSettings() {

    try {
        const sp = await fetch(settings).then(res => res.json());
        
        var birthDate = new Date(sp.dateOfBirth);
        var months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
        var formattedDate = ("0" + birthDate.getDate()).slice(-2) + " " +
                            months[birthDate.getMonth()] + " " +
                            birthDate.getFullYear();

        let homeText = `
            <div class="home-info padd-15">
                <h3 class="hello">Hello, my name is <span class="name">${sp.name}</span></h3>
                <h3 class="my-profession">I'm a <span class="typing">${sp.profession}</span></h3>
                <p>${sp.description}</p>
                <a href="#contact" class="btn hire-me">Hire Me</a>
            </div>
            <div class="home-img padd-15">
                <img src="assets/images/${sp.imageUrl}" alt="">
            </div>
        `;
        let cvText = `
            <a href="${sp.cvUrl}" class="btn">Download CV</a>
        `;
        let infoText = `
            <h3>I'm ${sp.name} and <span> ${sp.profession}</span></h3>
            <p>${sp.description}</p>
        `;
        let text = `
            <div class="contact-info-item padd-15">
                <div class="icon"><i class="fa fa-phone"></i></div>
                <h4>Call Us On</h4>
                <p>${sp.phoneNumber}</p>
            </div>
            <div class="contact-info-item padd-15">
                <div class="icon"><i class="fa fa-map-marker-alt"></i></div>
                <h4>Office</h4>
                <p>${sp.office}</p>
            </div>
            <div class="contact-info-item padd-15">
                <div class="icon"><i class="fa fa-envelope"></i></div>
                <h4>Linkedin</h4>
                <p><i class="fab fa-linkedin"><a href="${sp.linkedin}" target="_blank"></a></i>@TurkMvc</p>
            </div>
            <div class="contact-info-item padd-15">
                <div class="icon"><i class="fa fa-globe"></i></div>
                <h4>Website</h4>
                <p><a href="${sp.website}">Web site</a></p>
            </div>
        `;
        let aboutText = `
            <div class="info-item padd-15">
                <p>Birthday : <span>${formattedDate}</span></p>
            </div>
            <div class="info-item padd-15">
                <p>Age : <span>${sp.age}</span></p>
            </div>
            <div class="info-item padd-15">
                <p>Website : <span><a href="${sp.website}" target="_blank">TurkMvc</a></span></p>
            </div>
            <div class="info-item padd-15">
                <p>Linkedin : <span><a href="${sp.linkedin}" target="_blank"><i class="fa-brands fa-linkedin-in"></i></a></span></p>
            </div>
            <div class="info-item padd-15">
                <p>Degree : <span>${sp.degree}</span></p>
            </div>
            <div class="info-item padd-15">
                <p>City : <span>${sp.city}</span></p>
            </div>
            <div class="info-item padd-15">
                <p>Country : <span>${sp.country}</span></p>
            </div>
            <div class="info-item padd-15">
                <p>Freelance : <span>${sp.freelance}</span></p>
            </div>
        `;

        const infoEl = document.getElementById("aboutInfo");
        const el = document.getElementById("setting");
        const aboutEl = document.getElementById("aboutSetting");
        const cvEl = document.getElementById("cvUrl");
        const homeEl = document.getElementById("homeInfo");

        el.innerHTML = text;
        homeEl.innerHTML = homeText;
        cvEl.innerHTML = cvText;
        infoEl.innerHTML = infoText;
        aboutEl.innerHTML = aboutText;
    } catch (error) {
        console.error('Hata:', error);
    }
}

getSettings();
