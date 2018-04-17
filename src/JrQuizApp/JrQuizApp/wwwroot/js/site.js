// Write your JavaScript code.
// document.getElementsByClassName("BlockQ")
// document.getElementsByClassName("BlockQ")[0]
// var curCount = document.getElementsByClassName("BlockQ")[0].getAttribute("data-count");
// var choices = document.getElementsByName("inlineRadioOptions" + curCount);
// choices[0].checked
// choices[3].getAttribute("data-isCorrect")
// var questions = [];
// questions.push({ countId: 1, wasCorrect=true});

$(document).ready(function () {

    $('#SubmitQuiz').on('click', function () {

        var questions = [], isSelected = {}, k = 1, questionCount = 0, correctAnswers = 0;

        var block = document.getElementsByClassName("BlockQ");
        questionCount = block.length;

        for (var i = 0; i < block.length; i++) {
            var curCount = block[i].getAttribute("data-count");
            var choices = document.getElementsByName("inlineRadioOptions" + curCount);
            var choiceObj = {
                questionId: block[i].id,
                wasCorrect: false
            };
            var correctChoice = "";
            for (var j = 0; j < choices.length; j++) {
                var curChoice = choices[j];
                var isCorrect = curChoice.getAttribute("data-isCorrect");
                var isSelected = curChoice.checked;
               

                //var correctChoice = false;
                if (isSelected && isCorrect.toLowerCase() == 'true') {
                    //correctChoice = true;
                    choiceObj.wasCorrect = true;
                    correctAnswers++;
                }

                if (isCorrect.toLowerCase() == 'true') {
                    curChoice.parentElement.classList.add("correct-answer");
                    correctChoice = curChoice.parentElement.innerText;
                } else {
                    curChoice.parentElement.classList.add("incorrect-answer");
                }


                //if (choices.length > 0) {
                //    for (var i = 0; i < choices.length; i++) {
                //        if (isSelected[i] && isCorrect.toLowerCase() == 'true') {
                //            $('#AnsQ' + k).html('<div class="alert alert-success" role="alert"><span class="glyphicon glyphicon-thumbs-up" aria-hidden="true"></span> Correct answer</div>')
                //        }
                //        else {
                //            $('#AnsQ' + k).html('<div class="alert alert-danger" role="alert"> <span class="glyphicon glyphicon-thumbs-down" aria-hidden="true"></span> Incorrect answer - The Good Answer is <b>' + curChoice.isCorrect + '</b></div>');
                //        }
                //        k++;
                //    }
                //}
                //else {
                //    alert("Something is wrong");
                //}
            
            }
            questions.push(choiceObj);
            if (choiceObj.wasCorrect) {
                //block[i].classList.add("bg-success");
                $('#AnsQ' + (i + 1)).html('<div class="alert alert-success" role="alert"> Correct answer</div>')
            } else {
                //block[i].classList.add("bg-danger");
                $('#AnsQ' + (i + 1)).html('<div class="alert alert-danger" role="alert"> Incorrect answer. The correct answer is ' + correctChoice + '</div>');
            }
        }

        console.log("Score: " + (questionCount / correctAnswers));
        console.log(questions);


    });



});  

        //count Questions
        //var sel = $('#countQuections').text();

        //console.log(sel);

        //var resultQuiz = [], countQuestion = parseInt(sel), question = {}, j = 1;

        //for (var i = 1; i < countQuestion; i++) {
        //    question = {
        //        QuestionID: $('#ID_Q' + i).text(),
        //        QuestionText: $('#Q' + i).text(),
        //        AnswerQ: $('input[name=inlineRadioOptions' + i + ']:checked').val()
        //    };

        //    resultQuiz.push(question);
        //}

        //$.ajax({

        //    type: 'POST',
        //    url: '@Url.Action("Details", "Quiz")',
        //    data: { resultQuiz },

        //    success: function (response) {

        //        if (response.result.length > 0) {
        //            for (var i = 0; i < response.result.length; i++) {
        //                if (response.result[i].isCorrect === true) {

        //                    $('#AnsQ' + j).html('<div class="alert alert-success" role="alert"><span class="glyphicon glyphicon-thumbs-up" aria-hidden="true"></span> Correct answer</div>');
        //                }
        //                else {
        //                    $('#AnsQ' + j).html('<div class="alert alert-danger" role="alert"> <span class="glyphicon glyphicon-thumbs-down" aria-hidden="true"></span> Incorrect answer - The Good Answer is <b>' + response.result[i].AnswerQ + '</b></div>');
        //                }
        //                j++;
        //            }
        //        }
        //        else {
        //            alert("Something Wrong");
        //        }


                //console.log(response.result.length);  

        //    },
        //    error: function (response) {

        //    }
        //});

        //console.log(resultQuiz);

    //});



//});  