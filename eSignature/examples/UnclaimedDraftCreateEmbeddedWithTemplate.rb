require "dropbox-sign"

Dropbox::Sign.configure do |config|
  # Configure HTTP basic authorization: api_key
  config.username = "YOUR_API_KEY"

  # or, configure Bearer (JWT) authorization: oauth2
  # config.access_token = "YOUR_ACCESS_TOKEN"
end

unclaimed_draft_api = Dropbox::Sign::UnclaimedDraftApi.new

signer_1 = Dropbox::Sign::SubUnclaimedDraftTemplateSigner.new
signer_1.role = "Client"
signer_1.name = "George"
signer_1.email_address = "george@example.com"

cc_1 = Dropbox::Sign::SubCC.new
cc_1.role = "Accounting"
cc_1.email_address = "accounting@example.com"

data = Dropbox::Sign::UnclaimedDraftCreateEmbeddedWithTemplateRequest.new
data.client_id = "ec64a202072370a737edf4a0eb7f4437"
data.template_ids = ["61a832ff0d8423f91d503e76bfbcc750f7417c78"]
data.requester_email_address = "jack@dropboxsign.com"
data.signers = [signer_1]
data.ccs = [cc_1]
data.test_mode = true

begin
  result = unclaimed_draft_api.unclaimed_draft_create_embedded_with_template(data)
  p result
rescue Dropbox::Sign::ApiError => e
  puts "Exception when calling Dropbox Sign API: #{e}"
end
