# SDG6: Ensure availability and sustainable management of water and sanitation for all

## What is it about?

SDG 6, "Clean Water and Sanitation," is the UN goal to ensure availability and sustainable management of water and sanitation for all by 2030. It covers universal access to safe, affordable drinking water and to adequate sanitation and hygiene, along with improving water quality by reducing pollution and untreated wastewater. It also calls for using water more efficiently, managing water resources in an integrated way, and protecting water-related ecosystems such as rivers, wetlands and lakes. It has a strong focus on the needs of women, girls and people in vulnerable situations. It also promotes international cooperation and local community participation in water and sanitation management.

## What we are targeting

SDG 6 has eight targets: six outcome targets (6.1 to 6.6) and two means-of-implementation targets (6.a and 6.b).

**6.1 - Safe and Affordable Drinking Water**
By 2030, universal and equitable access to safe, affordable drinking water for all.

**6.2 - Sanitation and Hygiene**
By 2030, access to adequate and equitable sanitation and hygiene for all, ending open defecation, with special attention to women, girls and people in vulnerable situations.

**6.3 - Water Quality**
By 2030, improve water quality by reducing pollution, ending dumping, minimizing hazardous chemicals, halving untreated wastewater, and increasing recycling and safe reuse.

**6.4 - Water-Use Efficiency**
By 2030, substantially increase water-use efficiency across all sectors and ensure sustainable withdrawals and supply of freshwater, to address water scarcity and reduce the number of people suffering from it.

**6.5 - Integrated Water Resources Management**
By 2030, implement integrated water resources management at all levels, including cooperation across borders where appropriate.

**6.6 - Protect Water-Related Ecosystems**
By 2020, protect and restore water-related ecosystems such as mountains, forests, wetlands, rivers, aquifers and lakes.

**6.a - International Cooperation and Capacity-Building**
By 2030, expand international cooperation and support to developing countries in water and sanitation activities, such as water harvesting, desalination, efficiency, wastewater treatment and recycling.

**6.b - Local Community Participation**
Support and strengthen the participation of local communities in improving water and sanitation management.

## Specifics

The specific problem is how a community manages a limited, shared water supply so that it stays available and reaches everyone fairly.

At the SDG level, the problem is that billions of people lack reliable access to safe water, and where supply exists it is often scarce, unevenly shared, or interrupted by breakdowns. Our app doesn't try to solve all of that. It takes the management side of it, which breaks into four parts:

No visibility: nobody can easily see how much water is left in each source or which sources are usable right now.
Unfair distribution: with no limits, some people can draw far more than their share and leave others without.
Slow response to faults: a broken pipe or pump goes unreported or unfixed, so scarce water is lost and people are cut off.
Sources treated as identical: a dam, a tap and a storage tank fail and recover in different ways, and simple tracking ignores that.

## Classes

### Household

<< Attributes >>

- \_HouseholdID: Integer
- IDCounter: Integer
- \_Tap: Tap
- \_AmountUsedInTaps: Integer
- \_AmountUsedInBoreholes: Integer

<< Constructor >>

- +Household(Tap: Tap)

<< Property >>

- HouseholdID(): Integer {readonly}
- Tap(): Tap
- AmountUsedInTaps(): Integer
- AmountUsedInBoreholes: Integer

<< Methods >>

- -CanUseMoreWater(Amount: Integer): Boolean
- +UseTapWater(Amount: Integer): Void
- +UseBoreholeWater(Borehole: Borehole, Amount: Integer): Void
- +DisplayProfile(): String

### << Abstract >> WaterSource

<< Attributes >>

- -\_SourceID: Integer
- -IDCounter: Integer
- -\_AvailableAmount: Integer

<< Constructor >>

- +WaterSource(InitialAvailableAmount: Integer)

<< Property >>

- +SourceID(): Integer {readonly}
- +AvailableAmount(): Integer

<< Methods >>

- +CheckAvailability(): String
- +UseWater(Amount: Integer): Void

### Dam

<< Attributes >>

- -\_MaxCapacity: Integer
- -\_MaxUsableAmount: Integer
- -WaterFlowRate: Integer
- << Constructor >>
- +Dam(MaxCapacity: Integer, MaxUsableAmount: Integer, WaterFlowRate: Integer)

<< Property >>

- MaxCapacity(): Integer {readonly}
- MaxUsableAmount: Integer {readonly}
- WaterFlowRate(): Integer {readonly}

<< Methods >>

- +CheckAvailability(): String

### Borehole

<< Attributes >>

- -\_RefillRate: Integer

<< Constructor >>

- +Borehole()

<< Property >>

- +RefillRate(): Integer

<< Methods >>

- +CheckAvailability(): String

### Tap

<< Attributes >>

- -\_Dam: Dam
- -MaxUsableAmount: Integer {shared}
- << Constructor >>
- +Tap()

<< Property >>

- Dam(): Dam

<< Methods >>

- +CheckAvailability(): String

### Implementation file

#### IUsageLimitable

- MaxUsableAmount(): Integer {readonly property}
- CanUseMore(): Boolean

#### IRefillable
- RefillWater(): Void

## How would the app work

- For the purpose of the project we will be considering a week long timeframe. Limtiting how much water households use in their taps and how much water gets depleted in the dam. However there will be boreholes which have a refill rate so if overused may run out and households may have to wait for them to refill. For simulating the days we will add a button which moves the day to the next and after seven days resets to a new week. We would also have the dams listed and their current capcity same with the boreholes. And for the households you have request to see the information but the dam updates each time there is usage so it is alwasy available to see. We can also have the households show whenever we want to use it so one see how much capacity usage they have left.

## Interface

- New Day : btnNewDay [Changes day to the next]
- Use InHouse Water: btnHouseWater [Simply allows the household to use the water coming from their tap provided they have not reached their limit for the week]
- Use Borehole Water: btnUseBorehole [Simply allows household to use water from the borehole provided the borehole usage rate is not zero]
- Display Household Profile: btnHouseProfile [Shows the household Id and how much water they have used in their taps, how much water they have used from boreholes]
