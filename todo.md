# Backend

- [] create DB with designed schema.
    - [x] installed postgresql provider package for ef core.
    - [] create models from which DB tables will be created.
    - [] created domain models that are going to be used within the system.
        - should they include 'createdAt' and 'updatedAt' fields?
        - should join tables also have there own models?
    - [] create data transfer objects (DTOs)
        - used at the interface of the API to avoid over-posting (returning too much data of an entity like hashed passwords, etc.).
        - seperate from the domain models used within the system.

[] create endpoints for resources.

[] create services.
