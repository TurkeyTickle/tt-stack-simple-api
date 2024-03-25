using FastEndpoints;
using FluentValidation;

namespace TtStack.Api.Endpoints.Posts;

internal class CreatePostRequest
{
    public string? Title { get; set; }
    public string? Content { get; set; }
}

internal class CreatePostResponse
{
    public int Id { get; set; }
}

internal class RequestValidator : Validator<CreatePostRequest>
{
    public RequestValidator()
    {
        RuleFor(x => x.Title).NotEmpty();
        RuleFor(x => x.Content).NotEmpty();
    }
}

[HttpPost("/posts")]
internal class CreatePostEndpoint : Endpoint<CreatePostRequest, CreatePostResponse>
{   
    
}