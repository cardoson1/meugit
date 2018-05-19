using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShowDoMilhao
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public Jogador Jogador;
        public List<Pergunta> Perguntas;
        public int IDPerguntaAtual;

        public MainWindow()
        {
            Perguntas = new List<Pergunta>();
            InitializeComponent();
            IDPerguntaAtual = 0;

            var pergunta1 = new Pergunta
            {
                Enunciado = "Qual o pior time do mundo?",
                Resposta1 = "Real Madrid",
                Resposta2 = "Palmeiras",
                Resposta3 = "Salgueiro",
                Resposta4 = "Ibis",
                Resposta5 = "Santa Cruz",
                RespostaCorreta = 4
            };

            var pergunta2 = new Pergunta
            {
                Enunciado = "Se tivermos uma mulher presidente, como será o correto termo para chamarmos o marido dela?",
                Resposta1 = "Marido da presidente",
                Resposta2 = "Primeiro consorte",
                Resposta3 = "Primeiro damo",
                Resposta4 = "Primeiro cavalheiro",
                Resposta5 = "Nenhuma das respostas acima",
                RespostaCorreta = 4
            };

            var pergunta3 = new Pergunta
            {
                Enunciado = "O que você coloca em uma torradeira?",
                Resposta1 = "Torresmo",
                Resposta2 = "Bolo",
                Resposta3 = "Torrada",
                Resposta4 = "Pão!",
                Resposta5 = "Nenhuma das alternativas",
                RespostaCorreta = 4
            };

            var pergunta4 = new Pergunta
            {
                Enunciado = "A mãe de Mário tem três filhos. O primeiro se chama Março e o segundo se chama Abril. Qual é o nome do terceiro?",
                Resposta1 = "Maio",
                Resposta2 = "Mario",
                Resposta3 = "Júlio",
                Resposta4 = "Junho",
                Resposta5 = "Nenhuma das alternativas",
                RespostaCorreta = 2
            };

            var pergunta5 = new Pergunta
            {
                Enunciado = "O que pesa mais?",
                Resposta1 = "Uma tonelada de ferro",
                Resposta2 = "Uma Tonelada de pedras",
                Resposta3 = "Uma tonelada de algodão",
                Resposta4 = "Uma tonelada de penas!",
                Resposta5 = "Nenhuma das alternativas",
                RespostaCorreta = 5
            };

            var pergunta6 = new Pergunta
            {
                Enunciado = "Alguns meses têm 30 dias e outros 31. Quantos meses têm 28 dias durante um período de quatro anos?",
                Resposta1 = "12 meses",
                Resposta2 = "24 meses",
                Resposta3 = "48 meses",
                Resposta4 = "4 meses",
                Resposta5 = "Depende",
                RespostaCorreta = 3
            };

            var pergunta7 = new Pergunta
            {
                Enunciado = "Um trem elétrico segue no sentido norte-sul. O vento está no sentido contrário, ou seja, sul-norte. Qual a direção da fumaça desse trem?",
                Resposta1 = "Leste",
                Resposta2 = "Norte",
                Resposta3 = "Sul",
                Resposta4 = "Oeste",
                Resposta5 = "Nenhuma das alternativas",
                RespostaCorreta = 5
            };

            var pergunta8 = new Pergunta
            {
                Enunciado = "Você está em casa e acaba a luz, mas você está com uma caixa de fósforos na mão, ao lado de uma vela e um fogão a gás. O que você acende primeiro?",
                Resposta1 = "A vela",
                Resposta2 = "O fogão",
                Resposta3 = "A Luz",
                Resposta4 = "A Lanterna",
                Resposta5 = "Nenhuma das alternativas",
                RespostaCorreta = 5
            };

            var pergunta9 = new Pergunta
            {
                Enunciado = "Você fica doente e um médico recomenda um tratamento com três comprimidos, que devem ser tomados num intervalo de 10 horas cada. Se você toma o primeiro agora, em quanto tempo irá terminar o tratamento?",
                Resposta1 = "10 Horas",
                Resposta2 = "20 Horas",
                Resposta3 = "30 Horas",
                Resposta4 = "40 Horas",
                Resposta5 = "Nenhuma das alternativas",
                RespostaCorreta = 2
            };

            var pergunta10 = new Pergunta
            {
                Enunciado = "Um avião sobrevoava as duas Alemanhas durante a Guerra Fria, quando o piloto percebeu que ambas as turbinas falharam, e o avião caiu, no meio do nada. Onde você acha que devem enterrar os sobreviventes?",
                Resposta1 = "Alemanha Ocidental",
                Resposta2 = "Alemanha Oriental",
                Resposta3 = "No pais de Nascimento",
                Resposta4 = "No meio do nada",
                Resposta5 = "Nenhuma das alternativas",
                RespostaCorreta = 5
            };

            Perguntas.Add(pergunta1);
            Perguntas.Add(pergunta2);
            Perguntas.Add(pergunta3);
            Perguntas.Add(pergunta4);
            Perguntas.Add(pergunta5);
            Perguntas.Add(pergunta6);
            Perguntas.Add(pergunta7);
            Perguntas.Add(pergunta8);
            Perguntas.Add(pergunta9);
            Perguntas.Add(pergunta10);
        }

        private void MostrarPergunta(Pergunta pergunta)
        {
            LabelPontuacao.Content = "Pontuação " + Jogador.Pontuacao;
            TextBlockEnunciado.Text = pergunta.Enunciado;
            RadioButtonResposta1.Content = pergunta.Resposta1;
            RadioButtonResposta2.Content = pergunta.Resposta2;
            RadioButtonResposta3.Content = pergunta.Resposta3;
            RadioButtonResposta4.Content = pergunta.Resposta4;
            RadioButtonResposta5.Content = pergunta.Resposta5;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nome = TextBoxNomeJogador.Text;
            this.Jogador = new Jogador(nome, 0);
            GridTelaAbertura.Visibility = Visibility.Hidden;
            GridTelaPergunta.Visibility = Visibility.Visible;

            LabelNomeJogador.Content = 
                this.Jogador.Nome 
                + " jogando";

            MostrarPergunta(Perguntas[0]);

            Console.WriteLine(this.Jogador.Nome);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Checar se a resposta está correta
            var perguntaAtual = Perguntas[IDPerguntaAtual];
            var respostaPergunta = perguntaAtual.RespostaCorreta;

            int respostaSelecionada = 0;

            if(RadioButtonResposta1.IsChecked.Value) respostaSelecionada = 1;
            else if(RadioButtonResposta2.IsChecked.Value) respostaSelecionada = 2;
            else if(RadioButtonResposta3.IsChecked.Value) respostaSelecionada = 3;
            else if(RadioButtonResposta4.IsChecked.Value) respostaSelecionada = 4;
            else if(RadioButtonResposta5.IsChecked.Value) respostaSelecionada = 5;        

            if(respostaSelecionada == respostaPergunta)
            {
                Jogador.Pontuacao = Jogador.Pontuacao + 10;
            }
            else
            {
                MostrarFinal();
            }

            IDPerguntaAtual = IDPerguntaAtual + 1;

            if(IDPerguntaAtual < Perguntas.Count)
            {
                MostrarPergunta(Perguntas[IDPerguntaAtual]);
            }
            else
            {
                MostrarFinal();
            }
        }

        private void MostrarFinal()
        {
            GridTelaPergunta.Visibility = Visibility.Hidden;
            GridTelaFinal.Visibility = Visibility.Visible;

            TextBlockFinal.Text =
                "O jogo acabou!\n A sua pontuação foi: " +
                Jogador.Pontuacao +
                " pontos!";
        }
    }

    public class Pergunta
    {
        public string Enunciado;
        public string Resposta1;
        public string Resposta2;
        public string Resposta3;
        public string Resposta4;
        public string Resposta5;
        public int RespostaCorreta;
    }
}
