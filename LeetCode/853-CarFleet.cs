namespace LeetCode;

public static class _853_CarFleet
{
    public static int CarFleet(int target, int[] position, int[] speed)
    {
        var cars = position
            .Zip(speed, (pos, spd) => (pos, speed: spd))
            .OrderByDescending(car => car.pos)
            .ToArray();

        var stack = new List<double>();
        foreach (var car in cars)
        {
            var arrivalTime = (double)(target - car.pos) / car.speed;

            // If current car arrives later than the car in front, it can't catch up
            // So we add it as a new fleet
            if (stack.Count == 0 || arrivalTime > stack[^1])
            {
                stack.Add(arrivalTime);
            }
            // If current car arrives earlier or at the same time as the car in front,
            // we don't add it because it becomes part of the same fleet
        }

        return stack.Count;
    }
}
