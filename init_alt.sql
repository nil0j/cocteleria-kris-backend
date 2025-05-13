CREATE TABLE IF NOT EXISTS drinks
(
    id               INTEGER PRIMARY KEY AUTOINCREMENT,
    name             TEXT NOT NULL,
    price            INTEGER NOT NULL,
    alcoholic        INTEGER DEFAULT 0,
    flavour          TEXT NOT NULL,
    primary_type     TEXT NOT NULL,
    secondary_type   TEXT,
    recipe           TEXT,
    adelhyde         INTEGER DEFAULT 0,
    powdered_delta   INTEGER DEFAULT 0,
    bronson_extract  INTEGER DEFAULT 0,
    flanergide       INTEGER DEFAULT 0,
    karmotrine       INTEGER DEFAULT 0,
    needs_ice        INTEGER DEFAULT 0,
    needs_aged       INTEGER DEFAULT 0,
    preparation      TEXT DEFAULT 'mixed',
    shortcut         TEXT,
    description      TEXT,
    karmotrine_optional INTEGER DEFAULT 0
);

INSERT INTO drinks VALUES (1, 'Bad Touch', 250, 1, 'Sour', 'Classy', 'Vintage', '2 Bronson Extract, 2 Powdered Delta, 2 Flanergide and 4 Karmotrine. All on the rocks and mixed.', 0, 2, 2, 2, 4, 1, 0, 'mixed', '2xW, 2xE, 2xR, 4xT, A, all mixed.', 'We''re nothing but mammals after all.', 0);
INSERT INTO drinks VALUES (2, 'Beer', 200, 1, 'Bubbly', 'Classic', 'Vintage', '1 Adelhyde, 2 Bronson Extract, 1 Powdered Delta, 2 Flanergide and 4 Karmotrine. All mixed.', 1, 1, 2, 2, 4, 0, 0, 'mixed', '1xQ, 2xW, 1xE, 2xR, 4xT, all mixed.', 'Traditionally brewed beer has become a luxury, but this one''s pretty close to the real deal...', 0);
INSERT INTO drinks VALUES (3, 'Bleeding Jane', 200, 0, 'Spicy', 'Classic', 'Sobering', '1 Bronson Extract, 3 Powdered Delta and 3 Flanergide. All blended.', 0, 3, 1, 3, 0, 0, 0, 'blended', '1xW, 3xE, 3xR, all blended.', 'Say the name of this drink three times in front of a mirror and you''ll look like a fool.', 0);
INSERT INTO drinks VALUES (4, 'Bloom Light', 230, 1, 'Spicy', 'Promo', 'Bland', '4 Adelhyde, 1 Powdered Delta, 2 Flanergide and 3 Karmotrine. All aged, on the rocks and mixed.', 4, 1, 0, 2, 3, 1, 1, 'mixed', '4xQ, 1xE, 2xR, 3xT, A, S, all mixed.', 'It''s so unnecessarily brown....', 0);
INSERT INTO drinks VALUES (5, 'Blue Fairy', 170, 'Optional', 'Sweet', 'Girly', 'Soft', '4 Adelhyde, 1 Flanergide and optional Karmotrine. All aged and mixed.', 4, 0, 0, 1, 0, 0, 1, 'mixed', '4xQ, 1xR, optional T, S, all mixed.', 'One of these will make all your teeth turn blue. Hope you brushed them well.', 1);
INSERT INTO drinks VALUES (6, 'Brandtini', 250, 1, 'Sweet', 'Classy', 'Happy', '6 Adelhyde, 3 Powdered Delta and 1 Karmotrine. All aged and mixed.', 6, 3, 0, 0, 1, 0, 1, 'mixed', '6xQ, 3xE, 1xT, S, all mixed.', '8 out of 10 smug assholes would recommend it but they''re too busy being smug assholes.', 0);
INSERT INTO drinks VALUES (7, 'Cobalt Velvet', 280, 1, 'Bubbly', 'Classy', 'Burning', '2 Adelhyde, 3 Flanergide and 5 Karmotrine. All on the rocks and mixed.', 2, 0, 0, 3, 5, 1, 0, 'mixed', '2xQ, 3xR, 5xT, A, all mixed.', 'It''s like champaigne served on a cup that had a bit of cola left.', 0);
INSERT INTO drinks VALUES (8, 'Crevice Spike', 140, 'Optional', 'Sour', 'Manly', 'Sobering', '2 Powdered Delta, 4 Flanergide and optional Karmotrine. All blended.', 0, 2, 0, 4, 0, 0, 0, 'blended', '2xE, 4xR, optional T, all blended.', 'It will knock the drunkenness out of you or knock you out cold.', 1);
INSERT INTO drinks VALUES (9, 'Fluffy Dream', 170, 'Optional', 'Sour', 'Girly', 'Soft', '3 Adelhyde, 3 Powdered Delta and optional Karmotrine. All aged and mixed.', 3, 3, 0, 0, 0, 0, 1, 'mixed', '3xQ, 3xE, optional T, S, all mixed.', 'A couple of these will make your tongue feel velvet-y. More of them and you''ll be sleeping soundly.', 1);
INSERT INTO drinks VALUES (10, 'Fringe Weaver', 260, 1, 'Bubbly', 'Classy', 'Strong', '1 Adelhyde and 9 Karmotrine. All aged and mixed.', 1, 0, 0, 0, 9, 0, 1, 'mixed', '1xQ, 9xT, S, all mixed.', 'It''s like drinking ethylic alcohol with a spoonful of sugar.', 0);
INSERT INTO drinks VALUES (11, 'Frothy Water', 150, 0, 'Bubbly', 'Classic', 'Bland', '1 Adelhyde, 1 Bronson Extract, 1 Powdered Delta and 1 Flanergide. All aged and mixed.', 1, 1, 1, 1, 0, 0, 1, 'mixed', '1xQ, 1xW, 1xE, 1xR, S, all mixed.', 'PG-rated shows'' favorite Beer ersatz since 2040.', 0);
INSERT INTO drinks VALUES (12, 'Grizzly Temple', 220, 1, 'Bitter', 'Promo', 'Bland', '3 Adelhyde, 3 Bronson Extract, 3 Powdered Delta and 1 Karmotrine. All blended.', 3, 3, 3, 0, 1, 0, 0, 'blended', '3xQ, 3xW, 3xE, 1xT, all blended.', 'This one''s kinda unbearable. It''s mostly for fans of the movie it was used on.', 0);
INSERT INTO drinks VALUES (13, 'Gut Punch', 80, 'Optional', 'Bitter', 'Manly', 'Strong', '5 Bronson Extract, 1 Flanergide and optional Karmotrine. All aged and mixed.', 0, 0, 5, 1, 0, 0, 1, 'mixed', '5xW, 1xR, optional T, S, all mixed.', 'It''s supposed to mean "a punch made of innards", but the name actually described what you feel while drinking it.', 1);
INSERT INTO drinks VALUES (14, 'Marsblast', 170, 1, 'Spicy', 'Manly', 'Strong', '6 Bronson Extract, 1 Powdered Delta, 4 Flanergide and 2 Karmotrine. All blended.', 0, 1, 6, 4, 2, 0, 0, 'blended', '6xW, 1xE, 4xR, 2xT, all blended.', 'One of these is enough to leave your face red like the actual planet.', 0);
INSERT INTO drinks VALUES (15, 'Mercuryblast', 250, 1, 'Sour', 'Classy', 'Burning', '1 Adelhyde, 1 Bronson Extract, 3 Powdered Delta, 3 Flanergide and 2 Karmotrine. All on the rocks and blended.', 1, 3, 1, 3, 2, 1, 0, 'blended', '1xQ, 1xW, 3xE, 3xR, 2xT, A, all blended.', 'No thermometer was harmed in the creation of this drink.', 0);
INSERT INTO drinks VALUES (16, 'Moonblast', 180, 1, 'Sweet', 'Girly', 'Happy', '6 Adelhyde, 1 Powdered Delta, 1 Flanergide and 2 Karmotrine. All on the rocks and blended.', 6, 1, 0, 1, 2, 1, 0, 'blended', '6xQ, 1xE, 1xR, 2xT, A, all blended.', 'No relation to the Hadron cannon you can see on the moon for one week every month.', 0);
INSERT INTO drinks VALUES (17, 'Piano Man', 320, 1, 'Sour', 'Promo', 'Strong', '2 Adelhyde, 3 Bronson Extract, 5 Powdered Delta, 5 Flanergide and 3 Karmotrine. All on the rocks and mixed.', 2, 5, 3, 5, 3, 1, 0, 'mixed', '2xQ, 3xW, 5xE, 5xR, 3xT, A, all mixed.', 'This drink does not represent the opinions of the Bar Pianists Union or its associates.', 0);
INSERT INTO drinks VALUES (18, 'Piano Woman', 320, 1, 'Sweet', 'Promo', 'Happy', '5 Adelhyde, 5 Bronson Extract, 2 Powdered Delta, 3 Flanergide and 3 Karmotrine. All aged and mixed.', 5, 2, 5, 3, 3, 0, 1, 'mixed', '5xQ, 5xW, 2xE, 3xR, 3xT, S, all mixed.', 'It was originally called Pretty Woman, but too many people complained there should be a Piano Woman if there was a Piano Man.', 0);
INSERT INTO drinks VALUES (19, 'Pile Driver', 160, 1, 'Bitter', 'Manly', 'Burning', '3 Bronson Extract, 3 Flanergide and 4 Karmotrine. All mixed.', 0, 0, 3, 3, 4, 0, 0, 'mixed', '3xW, 3xR, 4xT, all mixed.', 'It doesn''t burn as hard on the tongue but you better not have a sore throat when drinking it...', 0);
INSERT INTO drinks VALUES (20, 'Sparkle Star', 150, 'Optional', 'Sweet', 'Girly', 'Happy', '2 Adelhyde, 1 Powdered Delta and optional Karmotrine. All aged and mixed.', 2, 1, 0, 0, 0, 0, 1, 'mixed', '2xQ, 1xE, optional T, S, all mixed.', 'They used to actually sparkle, but too many complaints about skin problem made them redesign the drink without sparkling.', 1);
INSERT INTO drinks VALUES (21, 'Sugar Rush', 150, 'Optional', 'Sweet', 'Girly', 'Happy', '2 Adelhyde, 1 Powdered Delta and optional Karmotrine. All mixed.', 2, 1, 0, 0, 0, 0, 0, 'mixed', '2xQ, 1xE, optional T, all mixed.', 'Sweet, light and fruity. As girly as it gets.', 1);
INSERT INTO drinks VALUES (22, 'Sunshine Cloud', 150, 'Optional', 'Bitter', 'Girly', 'Soft', '2 Adelhyde, 2 Bronson Extract and optional Karmotrine. All on the rocks and blended.', 2, 0, 2, 0, 0, 1, 0, 'blended', '2xQ, 2xW, optional T, A, all blended.', 'Tastes like old chocolate milk with its good smell intact. Some say it tastes like caramel too...', 1);
INSERT INTO drinks VALUES (23, 'Suplex', 160, 1, 'Bitter', 'Manly', 'Burning', '4 Bronson Extract, 3 Flanergide and 3 Karmotrine. All on the rocks and mixed.', 0, 0, 4, 3, 3, 1, 0, 'mixed', '4xW, 3xR, 3xT, A, all mixed.', 'A small twist on the Piledriver, putting more emphasis on the tongue burning and less on the throat burning.', 0);
INSERT INTO drinks VALUES (24, 'Zen Star', 210, 1, 'Sour', 'Promo', 'Bland', '4 Adelhyde, 4 Bronson Extract, 4 Powdered Delta, 4 Flanergide and 4 Karmotrine. All on the rocks and mixed.', 4, 4, 4, 4, 4, 1, 0, 'mixed', '4xQ, 4xW, 4xE, 4xR, 4xT, A, all mixed.', 'You''d think something so balanced would actually taste nice... you''d be dead wrong.', 0);
INSERT INTO drinks VALUES (25, 'Flaming Moai', 150, 1, 'Sour', 'Classy', 'Classic', '1 Adelhyde, 1 Bronson Extract, 2 Powdered Delta, 3 Flanergide and 5 Karmotrine. All mixed.', 1, 2, 1, 3, 5, 0, 0, 'mixed', '1xQ, 1xW, 2xE, 3xR, 5xT, all mixed.', 'N/A', 0);
INSERT INTO drinks VALUES (26, 'Absinthe', 500, 1, 'N/A', 'Bottled', 'N/A', 'N/A', 0, 0, 0, 0, 0, 0, 0, 'mixed', 'N/A', 'N/A', 0);
INSERT INTO drinks VALUES (27, 'A Fedora', 500, 1, 'N/A', 'Bottled', 'N/A', 'N/A', 0, 0, 0, 0, 0, 0, 0, 'mixed', 'N/A', 'N/A', 0);
INSERT INTO drinks VALUES (28, 'Mulan Tea', 500, 1, 'N/A', 'Bottled', 'N/A', 'N/A', 0, 0, 0, 0, 0, 0, 0, 'mixed', 'N/A', 'N/A', 0);
INSERT INTO drinks VALUES (29, 'Rum', 500, 1, 'N/A', 'Bottled', 'N/A', 'N/A', 0, 0, 0, 0, 0, 0, 0, 'mixed', 'N/A', 'N/A', 0);
