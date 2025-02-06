# FAQ Classification Model

This project implements a machine learning model using ML.NET to classify Frequently Asked Questions (FAQs) into predefined categories. It utilizes the Stochastic Dual Coordinate Ascent (SDCA) algorithm for multi-class classification with key evaluation metrics such as macro accuracy and log-loss.


## 📂 Project Structure

📁 DataAugmentation.cs       # Data enhancement and transformation  
📁 MyModel.cs                # Model structure for FAQ classification  
📁 Program.cs                # Main execution file  
📁 faq_dataset.csv           # Dataset for training and testing  
📁 faQClassification.sln     # Visual Studio solution file  
📁 faQClassification.csproj  # Project definition  
📄 LICENSE                   # License information  
📄 README.md                 # Project documentation  

## 🚀 Features

- Multiclass FAQ classification using SDCA algorithm
- Text preprocessing and data augmentation
- Evaluation with macro accuracy and log-loss metrics

## Getting Started

### Prerequisites

.NET SDK: Install the latest version of the .NET SDK from Microsoft's official site.
ML.NET: Integrated into the project for machine learning operations.

### 🛠️ Setup

1. Clone the repository:
   ```sh
   git clone https://github.com/iamrealvinnu/FAQ-Classification-Model.git
   cd FAQ-Classification-Model
   
2. Build the project:
   dotnet build

3. Run the project:
   dotnet run --project src/Program.cs

### 📊 Data
The dataset file faq_dataset.csv contains FAQs and their respective categories. Ensure that the file is placed in the appropriate directory for successful execution.

### Evaluation
The model's performance is evaluated using metrics such as log-loss.

### Usage
The trained model can classify new questions into predefined categories.

### Contributing
Contributions are welcome! Feel free to fork the repository and submit a pull request with your improvements.


