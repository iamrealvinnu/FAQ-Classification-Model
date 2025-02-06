# FAQ Classification Model

This repository contains a multi-classification model built using ML.NET to classify Frequently Asked Questions (FAQ) into predefined categories. It leverages the Stochastic Dual Coordinate Ascent (SDCA) algorithm for efficient and accurate multiclass classification.


## Project Structure

DataAugmentation.cs: Contains methods for augmenting the data to improve model performance.
faq_dataset.csv: Dataset file used for training and testing the model.
MyModel.cs: Contains the ML.NET model definition and training logic.
Program.cs: Main program file to execute the classification process.
faQClassification.csproj: Project file defining dependencies and settings.
faQClassification.sln: Solution file for the project.
.gitignore: Specifies files and directories to ignore in the repository.
LICENSE: Licensing information for the project.
README.md: Instructions and details about the repository.

## Features
FAQ Classification: Categorizes FAQs into predefined labels for better organization.
Algorithm: Uses the SDCA algorithm for multiclass classification.
Metrics: Macro accuracy and log-loss are utilized for performance evaluation.

## Getting Started

### Prerequisites

.NET SDK: Install the latest version of the .NET SDK from Microsoft's official site.
ML.NET: Integrated into the project for machine learning operations.

### Setup

1. Clone the repository:
   ```sh
   git clone https://github.com/iamrealvinnu/FAQ-Classification-Model.git
   cd FAQ-Classification-Model
   
2. Build the project:
   dotnet build

3. Run the project:
   dotnet run --project src/Program.cs

### Data
The dataset file faq_dataset.csv contains FAQs and their respective categories. Ensure that the file is placed in the appropriate directory for successful execution.

### Evaluation
The model's performance is evaluated using metrics such as log-loss.

### Usage
The trained model can classify new questions into predefined categories.

### Contributing
Contributions are welcome! Feel free to fork the repository and submit a pull request with your improvements.


