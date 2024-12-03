INSERT INTO bfloresFA24.Categories
(CategoryName, CategoryDescription)
VALUES
('Skis', 'The best pairs of runners, designed for alpine, freestyle, or cross-country.'),
('Snowboards', 'Awesome boards for every condition: all-mountain, park, powder, or freeride.'),
('Ski Boots', 'The essential skiing footwear needed for comfort, power, and stability.'),
('Snowboard Boots', 'All kinds of board boots to fit all styles. From stiff to soft flex, and BOA to quick-pull laces.'),
('Ski Bindings', 'Get power transfer and safe releases with our variety of ski bindings.'),
('Snowboard Bindings', 'Our bindings give you power and control over your board as well as support for your ankles.'),
('Snow Sports Clothing', 'Insulated and snow-proof apparel to keep you warm and sharp on the mountain.'),
('Snow Sports Gear', 'The accessories you''ll need to stay frosty. Goggles, helmets, poles, and more.');
Go

INSERT INTO bfloresFA24.Inventory
(ItemName, ItemDescription, CategoryID, RetailPrice, Cost, Quantity, RestockThreshold)
VALUES
('2025 Atomic Bent 100 Skis', 'All-mountain freeride skis with a playful yet stable design for varied terrain.', 100, 649.95, 450, 25, 30),
('2025 LINE Pandora 85 Skis', 'Lightweight women’s skis ideal for groomed runs and all-mountain exploration.', 100, 449.95, 360, 48, 30),
('2025 Nordica Enforcer 94 Skis', 'Versatile and powerful skis with exceptional edge grip for intermediate to advanced skiers.', 100, 749.95, 525, 69, 30),
('2024 K2 Reckoner 102 Skis', 'Freestyle skis offering a mix of stability and playfulness, ideal for park and all-mountain use.', 100, 599.95, 300, 41, 30),
('2025 Salomon QST X Skis', 'High-performance all-mountain skis with enhanced floatation for powder and carving capability.', 100, 799.95, 560, 33, 30),

('2025 Burton Custom X Snowboard', 'High-performance board designed for aggressive riders seeking precision and speed.', 101, 749.95, 525, 36, 30),
('K2 Alchemist Snowboard', 'Durable and responsive snowboard tailored for expert freeriders.', 101, 799.95, 560, 123, 30),
('2024 Ride Warpig Snowboard', 'Compact and versatile, excelling in freestyle and all-mountain conditions.', 101, 499.95, 375, 149, 30),
('Jones Mountain Twin Snowboard', 'All-mountain board with a freestyle-oriented shape for playful yet controlled riding.', 101, 599.95, 420, 27, 30),
('2025 Never Summer Proto FR Snowboard', 'Asymmetrical twin snowboard optimized for freestyle tricks and all-mountain carving.', 101, 619.95, 430, 111, 30),

('2025 Salomon S Pro 120 GW Ski Boots', 'Comfortable, high-performance boots with precise power transmission.', 102, 599.95, 420, 31, 20),
('Atomic Hawx Prime 130 Ski Boots', 'Lightweight boots offering maximum power and a customizable fit for aggressive skiers.', 102, 699.95, 420, 71, 20),
('Tecnica Mach1 MV 120 Ski Boots', 'Versatile boots balancing performance and comfort for intermediate to advanced skiers.', 102, 649.99, 460, 34, 20),
('Dalbello Panterra 120 GW Ski Boots', 'Adjustable and forgiving boots for all-mountain versatility and comfort.', 102, 549.99, 400, 36, 20),
('Nordica Sportmachine 100 Ski Boots', 'Comfortable boots with medium flex, perfect for beginner to intermediate skiers.', 102, 399.95, 300, 93, 20),

('Burton Ion Snowboard Boots', 'High-performance boots for advanced riders seeking responsive support.', 103, 449.95, 340, 59, 20),
('Ride Lasso Pro Snowboard Boots', 'Dual Boa boots combining comfort and precision for all-mountain snowboarding.', 103, 349.95, 280, 35, 20),
('K2 Maysis Snowboard Boots', 'Durable and warm boots featuring an intuitive Boa lacing system for a custom fit.', 103, 369.95, 280, 75, 20),
('Salomon Dialogue Snowboard Boots', 'Flexible boots for freestyle and park riders who value comfort and versatility.', 103, 329.95, 250, 36, 20),
('ThirtyTwo Lashed Double Boa Snowboard Boots', 'Reliable boots with a dual Boa system for quick and secure adjustments.', 103, 359.95, 215, 38, 20),

('2025 Marker Griffon 13 ID Ski Bindings', 'Versatile bindings compatible with various boot types, offering reliability and safety.', 104, 269.99, 200, 55, 20),
('Salomon Warden MNC 13 Ski Bindings', 'Multi-norm bindings providing exceptional power transmission and adaptability.', 104, 249.99, 180, 72, 20),
('Look Pivot 15 GW Ski Ski Bindings', 'Durable bindings with precise release mechanisms for expert skiers.', 104, 399.95, 300, 22, 20),
('Atomic Shift MNC 13 Ski Bindings', 'Lightweight touring bindings with downhill capability and boot versatility.', 104, 599.95, 420, 92, 20),
('Tyrolia Attack 14 GW Ski Bindings', 'Compact, high-performance bindings suitable for all-mountain skiing.', 104, 229.95, 175, 56, 20),

('Union Atlas Snowboard Bindings', 'Designed for intermediate to advanced riders, these bindings offer firm flex and a lightweight nylon baseplate with aluminum heelcups for durability and responsiveness.', 105, 369.95, 260, 47, 20),
('Burton Step On Women’s Snowboard Bindings', 'Featuring the Step On system for quick and secure boot entry, these bindings combine all-mountain performance with unmatched convenience.', 105, 299.95, 200, 27, 20),
('Jones Mercury Snowboard Bindings', 'Built for all-mountain versatility, these bindings have a medium-stiff flex and advanced dampening to balance control and comfort on any terrain.', 105, 349.95, 250, 24, 20),

('Arc''teryx Sabre LT Jacket', 'Lightweight, weatherproof jacket designed for backcountry skiing and snowboarding.', 106, 699, 490, 25, 15),
('The North Face Thermoball Eco Jacket', 'Insulated, packable jacket offering eco-friendly warmth in cold conditions.', 106, 230, 180, 27, 15),
('Patagonia PowSlayer Bib Pants', 'Durable, waterproof pants with excellent breathability for serious skiers and snowboarders.', 106, 699.99, 400, 39, 15),

('Smith I/O MAG Goggles', 'Premium goggles featuring interchangeable lenses for clear vision in changing light conditions.', 107, 280, 210, 33, 30),
('Black Diamond Traverse Ski Poles', 'Lightweight and adjustable poles perfect for skiing or snowshoeing.', 107, 99.95, 75, 26, 20),
('Dakine Heli Pro 20L Backpack', 'Compact, feature-rich backpack with storage for avalanche gear and hydration systems.', 107, 120, 90, 20, 10);
GO