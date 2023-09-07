<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="gallery.aspx.cs" Inherits="PropertyPortal.gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #outputfile {
            width: 100%;
            min-height: 150px;
            display: flex;
            justify-content: flex-start;
            flex-wrap: wrap;
            gap: 15px;
            position: relative;
            border-radius: 5px;
        }

            #outputfile .image {
                height: 150px;
                border-radius: 5px;
                box-shadow: 0 0 5px rgba(0, 0, 0, 0.15);
                overflow: hidden;
                position: relative;
            }

                #outputfile .image img {
                    height: 100%;
                    width: 100%;
                }

                #outputfile .image span {
                    position: absolute;
                    right: 5px;
                    cursor: pointer;
                    font-size: 35px;
                    color: black;
                    top: -10px;
                }

                    #outputfile .image span:hover {
                        opacity: 0.8;
                    }

            #outputfile .span--hidden {
                visibility: hidden;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input type="file" id="fileupload" multiple="multiple" accept="image/jpeg, image/png, image/jpg">
    <output id="outputfile"></output>
    <script>
        const output = document.getElementById("outputfile");
        const input = document.getElementById("fileupload");
        let imagesArray = [];
        input.addEventListener("change", () => {
            const files = input.files
            for (let i = 0; i < files.length; i++) {
                imagesArray.push(files[i])
            }
            displayImages()
        })
        function displayImages() {
            let images = ""
            imagesArray.forEach((image, index) => {
                images += `<div class="image">
                <img src="${URL.createObjectURL(image)}" alt="image">
                <span onclick="deleteImage(${index})">&times;</span>
              </div>`
            })
            output.innerHTML = images
        }

        function deleteImage(index) {
            imagesArray.splice(index, 1)
            displayImages()
        }
    </script>
</asp:Content>
