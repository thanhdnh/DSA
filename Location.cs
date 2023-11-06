class Location{
    public string name;
    public int population;
    public float income;
    public Location(string name, int population, 
                                    float income){
        this.name = name;
        this.population = population;
        this.income = income;
    }
    override public string ToString(){
        return $"Location[{name}, {population}, {income}]";
    }
}