module SpaceAge

type Planet =
    | Earth
    | Mercury
    | Venus
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

let getOrbitalPeriod (planet: Planet): decimal =
    let earthYear = 31557600m
    match planet with
    | Earth -> earthYear
    | Mercury -> earthYear * 0.2408467m
    | Venus -> earthYear * 0.61519726m
    | Mars -> earthYear * 1.8808158m
    | Jupiter -> earthYear * 11.862615m
    | Saturn -> earthYear * 29.447498m
    | Uranus -> earthYear * 84.016846m
    | Neptune -> earthYear * 164.79132m

let spaceAge (planet: Planet) (seconds: decimal): decimal = System.Decimal.Round(seconds / getOrbitalPeriod planet, 2)
