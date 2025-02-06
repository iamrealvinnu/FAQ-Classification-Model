# FAQ Classification Model

This repository contains a multi-classification model using ML.NET to classify frequently asked questions (FAQ) into predefined categories.

## Project Structure

- `data/`: Contains the dataset file (`faq_data.csv`).
- `src/`: Contains the source code (`Program.cs`).
- `models/`: Contains the trained model (`trained_model.zip`).
- `README.md`: Project overview and instructions.
- `.gitignore`: Specifies files to ignore in the repository.
- `LICENSE`: License information.

## Getting Started

### Prerequisites

- .NET SDK
- ML.NET

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
The dataset (faq_data.csv) contains questions and their corresponding categories.

### Training the Model
The model is defined and trained in src/Program.cs. The trained model is saved in the models/ directory.

### Evaluation
The model's performance is evaluated using metrics such as log-loss.

### Usage
The trained model can classify new questions into predefined categories.
