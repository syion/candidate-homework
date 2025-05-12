-- Sample data for Owners and Pets

-- Insert sample Owners
INSERT INTO dbo.Owners (Email, FirstName, LastName, ApiKey)
VALUES 
    ('john.doe@example.com', 'John', 'Doe', '11111111-1111-1111-1111-111111111111'),
    ('jane.smith@example.com', 'Jane', 'Smith', '22222222-2222-2222-2222-222222222222'),
    ('robert.johnson@example.com', 'Robert', 'Johnson', '33333333-3333-3333-3333-333333333333'),
    ('sarah.williams@example.com', 'Sarah', 'Williams', '44444444-4444-4444-4444-444444444444'),
    ('michael.brown@example.com', 'Michael', 'Brown', '55555555-5555-5555-5555-555555555555');

-- Insert sample Pets (assuming the IDENTITY values start from 1)
INSERT INTO dbo.Pets (Name, OwnerId, Species, Description, Color, Age)
VALUES 
    -- John's pets
    ('Max', 1, 'Dog', 'Friendly Golden Retriever', 'Golden', 5),
    ('Whiskers', 1, 'Cat', 'Long-haired calico', 'Calico', 3),
    ('Buddy', 1, 'Hamster', 'Small and active', 'Brown', 1),  -- Same name as Jane's dog
    
    -- Jane's pets
    ('Buddy', 2, 'Dog', 'Energetic Labrador', 'Black', 2),    -- Same name as John's hamster
    ('Felix', 2, 'Cat', 'Lazy tabby cat', 'Gray', 7),
    ('Tweety', 2, 'Bird', 'Yellow canary', 'Yellow', 1),
    ('Max', 2, 'Snake', 'Ball python', 'Black and Yellow', 3),  -- Same name as John's dog
    
    -- Robert's pets
    ('Rex', 3, 'Dog', 'German Shepherd', 'Brown', 4),
    ('Whiskers', 3, 'Ferret', 'Playful and curious', 'White', 2),  -- Same name as John's cat
    
    -- Sarah's pets
    ('Nemo', 4, 'Fish', 'Clownfish', 'Orange', 1),
    ('Dory', 4, 'Fish', 'Blue tang', 'Blue', 2),
    ('Bubbles', 4, 'Fish', 'Yellow tang', 'Yellow', 1),
    ('Rex', 4, 'Lizard', 'Bearded dragon', 'Tan', 3),  -- Same name as Robert's dog
    
    -- Michael's pets
    ('Rocky', 5, 'Rabbit', 'Dwarf rabbit', 'White', 2),
    ('Buddy', 5, 'Parrot', 'African grey', 'Grey', 10);  -- Same name as Jane's dog and John's hamster
