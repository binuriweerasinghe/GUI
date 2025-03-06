document.addEventListener("DOMContentLoaded", () => {
    // Login Functionality
    const loginForm = document.getElementById("loginForm");
    if (loginForm) {
        loginForm.addEventListener("submit", (e) => {
            e.preventDefault();
            const username = document.getElementById("username").value;
            const password = document.getElementById("password").value;

            const storedUsername = localStorage.getItem("username");
            const storedPassword = localStorage.getItem("password");

            if (username === storedUsername && password === storedPassword) {
                localStorage.setItem("loggedInUser", username);
                window.location.href = "home.html";
            } else {
                alert("Invalid Username or Password");
            }
        });
    }

    // Signup Functionality
    const signupForm = document.getElementById("signupForm");
    if (signupForm) {
        signupForm.addEventListener("submit", (e) => {
            e.preventDefault();
            const newUsername = document.getElementById("newUsername").value;
            const newPassword = document.getElementById("newPassword").value;

            if (newUsername && newPassword) {
                localStorage.setItem("username", newUsername);
                localStorage.setItem("password", newPassword);
                alert("Account Created! Please Login.");
                window.location.href = "index.html";
            } else {
                alert("Please enter a username and password.");
            }
        });
    }

    // Display Logged-in Username
    const usernameDisplay = document.getElementById("loggedInUser");
    if (usernameDisplay) {
        const loggedInUser = localStorage.getItem("loggedInUser");
        if (loggedInUser) {
            usernameDisplay.textContent = `Hi, ${loggedInUser}`;
        } else {
            window.location.href = "index.html"; // Redirect to login if not logged in
        }
    }

    // Logout Functionality
    const logoutBtn = document.getElementById("logoutBtn");
    if (logoutBtn) {
        logoutBtn.addEventListener("click", () => {
            localStorage.removeItem("loggedInUser");
            window.location.href = "index.html";
        });
    }

    // Workout Plan Data for Seven Days
    const workouts = {
        monday: {
            title: "Monday Workout",
            image: "images/monday.jpg",
            exercises: [
                "🏋️ Push-ups (3 sets of 15)",
                "🏋️ Squats (3 sets of 20)",
                "🏋️ Jump Rope (3 sets of 30 sec)",
                "🏋️ Plank (3 sets of 40 sec)",
                "🏋️ Mountain Climbers (3 sets of 20 each leg)",
                "🏋️ Burpees (3 sets of 10)",
                "🏋️ Lunges (3 sets of 15 each leg)",
                "🏋️ Bicycle Crunches (3 sets of 20)"
            ]
        },
        tuesday: {
            title: "Tuesday Workout",
            image: "images/tuesday.jpg",
            exercises: [
                "🏋️ Deadlifts (3 sets of 12)",
                "🏋️ Bench Press (3 sets of 15)",
                "🏋️ Triceps Dips (3 sets of 12)",
                "🏋️ Russian Twists (3 sets of 20)",
                "🏋️ Glute Bridges (3 sets of 15)",
                "🏋️ Wall Sit (3 sets of 45 sec)",
                "🏋️ Resistance Band Pulls (3 sets of 20)",
                "🏋️ High Knees (3 sets of 30 sec)"
            ]
        },
        wednesday: {
            title: "Wednesday Workout",
            image: "images/wednesday.jpg",
            exercises: [
                "🏋️ Pull-ups (3 sets of 10)",
                "🏋️ Kettlebell Swings (3 sets of 20)",
                "🏋️ Lateral Raises (3 sets of 15)",
                "🏋️ Treadmill Sprint (3 sets of 1 min)",
                "🏋️ Seated Shoulder Press (3 sets of 15)",
                "🏋️ Hanging Leg Raises (3 sets of 12)",
                "🏋️ Rowing Machine (3 sets of 5 min)",
                "🏋️ Side Plank (3 sets of 30 sec)"
            ]
        },
        thursday: {
            title: "Thursday Workout",
            image: "images/thursday.jpg",
            exercises: [
                "🏋️ Bicep Curls (3 sets of 15)",
                "🏋️ Hammer Curls (3 sets of 15)",
                "🏋️ Bulgarian Split Squats (3 sets of 12)",
                "🏋️ Ab Rollouts (3 sets of 15)",
                "🏋️ Medicine Ball Slams (3 sets of 20)",
                "🏋️ Barbell Squats (3 sets of 12)",
                "🏋️ Plank Shoulder Taps (3 sets of 20)",
                "🏋️ Jumping Jacks (3 sets of 40)"
            ]
        },
        friday: {
            title: "Friday Workout",
            image: "images/friday.jpg",
            exercises: [
                "🏋️ Single-Leg Deadlifts (3 sets of 12 each leg)",
                "🏋️ Farmer’s Walk (3 sets of 30 sec)",
                "🏋️ Hanging Knee Raises (3 sets of 12)",
                "🏋️ Landmine Press (3 sets of 15)",
                "🏋️ Sprint Intervals (3 sets of 1 min)",
                "🏋️ Skipping Rope (3 sets of 45 sec)",
                "🏋️ Box Jumps (3 sets of 12)",
                "🏋️ Dumbbell Snatch (3 sets of 15)"
            ]
        },
        saturday: {
            title: "Saturday Workout",
            image: "images/saturday.jpg",
            exercises: [
                "🏋️ Foam Rolling (5 min)",
                "🏋️ Light Jogging (10 min)",
                "🏋️ Stretching (15 min)",
                "🏋️ Yoga Poses (20 min)",
                "🏋️ Breathing Exercises (5 min)",
                "🏋️ Tai Chi Movements (10 min)",
                "🏋️ Balance Training (10 min)",
                "🏋️ Core Strengthening (15 min)"
            ]
        },
        sunday: {
            title: "Sunday Workout",
            image: "images/sunday.jpg",
            exercises: [
                "🏋️ Rest Day 🛌",
                "🏋️ Active Recovery Walk (20 min)",
                "🏋️ Stretching (10 min)",
                "🏋️ Meditation (10 min)",
                "🏋️ Deep Breathing Exercises (10 min)",
                "🏋️ Mobility Work (15 min)",
                "🏋️ Light Cycling (20 min)",
                "🏋️ Foam Rolling (10 min)"
            ]
        }
    };

    // Function to Display Workout
    function showWorkout(day) {
        const details = document.getElementById("workout-details");
        const title = document.getElementById("day-title");
        const image = document.getElementById("day-image");
        const list = document.getElementById("exercise-list");

        title.textContent = workouts[day].title;
        image.src = workouts[day].image;
        list.innerHTML = "";

        workouts[day].exercises.forEach(exercise => {
            let li = document.createElement("li");
            li.textContent = exercise;
            list.appendChild(li);
        });

        details.style.display = "block";
    }

    // Attach Event Listeners for Workout Days
    document.querySelectorAll(".day").forEach(day => {
        day.addEventListener("click", () => showWorkout(day.textContent.toLowerCase()));
    });

    // Calories Calculation
    function updateCalories() {
        let breakfast = parseInt(document.getElementById("breakfast-food").value);
        let lunch = parseInt(document.getElementById("lunch-food").value);
        let dinner = parseInt(document.getElementById("dinner-food").value);

        document.getElementById("breakfast-calories").textContent = breakfast;
        document.getElementById("lunch-calories").textContent = lunch;
        document.getElementById("dinner-calories").textContent = dinner;

        let totalCalories = breakfast + lunch + dinner;
        document.getElementById("total-calories").textContent = totalCalories;
    }

    document.getElementById("calculate-calories").addEventListener("click", updateCalories);

    // Pre-Filled Meal Plans
    const mealPlans = {
        monday: ["Oatmeal with Berries", "Grilled Chicken & Rice", "Salmon & Veggies"],
        tuesday: ["Scrambled Eggs & Toast", "Turkey Sandwich", "Vegetable Stir Fry"],
        wednesday: ["Smoothie Bowl", "Quinoa & Lentils", "Tuna Salad"],
        thursday: ["Pancakes with Honey", "Chicken Caesar Salad", "Lentil Soup"],
        friday: ["Yogurt & Granola", "Fish & Brown Rice", "Grilled Tofu & Vegetables"],
        saturday: ["Avocado Toast", "Beef Stir Fry", "Shrimp & Pasta"],
        sunday: ["Banana Pancakes", "Chicken Wrap", "Mushroom Soup & Bread"]
    };

    function showMealPlan(day) {
        let mealList = document.getElementById("meal-list");
        let title = document.getElementById("day-title");
        let details = document.getElementById("meal-plan-details");

        title.textContent = `${day.charAt(0).toUpperCase() + day.slice(1)} Meal Plan`;
        mealList.innerHTML = "";
        
        mealPlans[day].forEach(meal => {
            let li = document.createElement("li");
            li.textContent = meal;
            mealList.appendChild(li);
        });

        details.style.display = "block";
    }

    document.querySelectorAll(".day-btn").forEach(button => {
        button.addEventListener("click", () => {
            showMealPlan(button.getAttribute("data-day"));
        });
    });
    // Load saved profile data
    document.getElementById("weight").value = localStorage.getItem("weight") || "";
    document.getElementById("height").value = localStorage.getItem("height") || "";
    document.getElementById("goal").value = localStorage.getItem("goal") || "";
    document.getElementById("sleep").value = localStorage.getItem("sleep") || "";
    document.getElementById("mood").value = localStorage.getItem("mood") || "";

    // Save profile data
    document.getElementById("save-profile").addEventListener("click", function () {
        localStorage.setItem("weight", document.getElementById("weight").value);
        localStorage.setItem("height", document.getElementById("height").value);
        localStorage.setItem("goal", document.getElementById("goal").value);
        localStorage.setItem("sleep", document.getElementById("sleep").value);
        localStorage.setItem("mood", document.getElementById("mood").value);
        alert("Profile saved successfully!");
    });

    // Logout function
    document.getElementById("logoutBtn").addEventListener("click", function () {
        localStorage.clear(); // Clear all saved data
        alert("Logged out!");
        window.location.href = "index.html"; // Redirect to login page
    });

});
