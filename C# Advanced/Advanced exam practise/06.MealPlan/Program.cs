
Queue<string> meals = new Queue<string> (
    Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    );

Stack<int> maximumCaloriesIntakePerDay = new Stack<int> (
    Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    );

Dictionary<string, int> caloriesPerMeal = new Dictionary<string, int>();
caloriesPerMeal["salad"] = 350;
caloriesPerMeal["soup"] = 490;
caloriesPerMeal["pasta"] = 680;
caloriesPerMeal["steak"] = 790;

int caloriesLeft = 0;
int mealsCounter = 0;

while (maximumCaloriesIntakePerDay.Any() && meals.Any())
{
    int left = maximumCaloriesIntakePerDay.Peek();

    for (int i = maximumCaloriesIntakePerDay.Peek(); i >= 0; i = left)
    {
        string currentMeal = meals.Peek();
        int currentMealCalories = caloriesPerMeal[currentMeal];

        left -= caloriesPerMeal[currentMeal];

        if (i - currentMealCalories > 0)
        {
            meals.Dequeue();
            mealsCounter++;
        }
        else if (i - currentMealCalories == 0)
        {
            meals.Dequeue();
            maximumCaloriesIntakePerDay.Pop();
            mealsCounter++;
        }
        else if (i - currentMealCalories < 0)
        {
            maximumCaloriesIntakePerDay.Pop();
            caloriesLeft = currentMealCalories - i;
            meals.Dequeue();
            mealsCounter++;

            if (maximumCaloriesIntakePerDay.Count > 0)
            {
                maximumCaloriesIntakePerDay.Push(maximumCaloriesIntakePerDay.Pop() - caloriesLeft);
                caloriesLeft = 0;
            }
        }

        if (meals.Count == 0)
        {
            break;
        }
    }
}

if (!meals.Any())
{
    Console.WriteLine($"John had {mealsCounter} meals.");
    Console.WriteLine($"For the next few days, he can eat {string.Join(", ", maximumCaloriesIntakePerDay)} calories.");
}
else
{
    Console.WriteLine($"John ate enough, he had {mealsCounter} meals.");
    Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
}