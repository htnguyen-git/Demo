# Chữ ký điện tử eSignature
## eSignature là gì
- Chữ ký eSignature là phương pháp ký số.
- Dùng để xác nhận sự đồng ý hoặc chứng thực của người ký trên tài liệu điện tử.
- Có 3 loại:
    - Chữ ký đơn giản (simple electronic signature): là chữ ký được tạo ra bằng cách sử dụng phương tiện thiết bị điện tử như bút điện tử, chuột, hoặc bàn phím để vẽ hoặc gõ tên người ký
    - Chữ ký điện tử nâng cao (advanced electronic signature): Được tạ ra bằng cách sử dụng công nghệ mã hóa, hoặc các phương pháp bảo mật khác. Đảm bảo tính toàn vẹn, xác thực, không thể chối bỏ 
    - Chữ ký điện tử cao cấp (qualified electronic signature): Là chữ ký điện tử nâng cao, được cấp bởi một tổ chức chứng thực được ủy quyền bởi nhà nước, đảm bảo tính hợp pháp và pháp lý

## Tại sao sử dụng 
- Giúp tiết kiệm thời gian và giảm bớt chi phí cho các giao dịch, bởi vì nó không cần đến sự xuất hiện của các bên liên quan trong một văn phòng để ký tài liệu
- Được quy định trong luật điện tử số 51/2005/QH11 và các văn bản hướng dẫn liên quan.
- Được chính phủ Việt Nam khuyến khích và hỗ trợ

## Tính hợp pháp
- Tùy thuộc vào quy định của quốc gia hoặc khu vực cụ thể, các loại chữ ký điện tử có thể có tính pháp lý khác nhau.
- Một số nước coi chữ ký điện tử là pháp lý tương đương với chữ ký trên giấy tờ, trong khi các nước khác có thể yêu cầu các loại chữ ký điện tử cụ thể hơn để đáp ứng các yêu cầu pháp lý.
- Ở Việt Nam thì chữ ký điện tử eSignature là hợp pháp

## Các bước để tạo và xác thực
- Tạo chữ ký điện tử: Một chữ ký điện tử có thể được tạo ra bằng cách sử dụng một công cụ tạo chữ ký điện tử trực tuyến hoặc phần mềm đặc biệt. Thông thường, chữ ký điện tử được tạo bằng cách mã hóa thông tin về người ký vào một chuỗi ký tự đặc biệt.
- Gắn chữ ký điện tử vào tài liệu: Sau khi đã tạo được chữ ký điện tử, bạn cần phải gắn chữ ký vào tài liệu. Việc này có thể được thực hiện thông qua các phần mềm chữ ký điện tử hoặc các công cụ tạo chữ ký điện tử.
- Xác thực chữ ký điện tử: Khi một tài liệu đã được ký bằng chữ ký điện tử, người nhận có thể xác thực tính toàn vẹn của tài liệu bằng cách sử dụng các công cụ xác thực chữ ký điện tử. Các công cụ này sẽ kiểm tra chữ ký điện tử để đảm bảo rằng nó đã được tạo bởi người ký chính xác và không bị thay đổi từ lúc ký đến lúc xác thực.

## Ứng dụng trong app
- TODO
- Ngày viết: 2023/02/17 
- Embedded signing
- Sử dụng chữ ký điện tử đơn giản.
- Tích hợp eSignature của Dropbox sign (hello sign)
- Các bước tích hợp - nhiều user, một tài khoản dropbox
    - Tạo một ứng dụng trên trang quản trị ứng dụng của Dropbox (https://www.dropbox.com/developers/apps). Trong phần setting, bật chế độ team folder access
    - Cài đặt SDK của dropbox (https://www.dropbox.com/developers/documentation/dotnet#install).
    - Đăng nhập vào tài khoản Dropbox của người dùng để xác thực truy cập. Dùng OAuth2Authorization , example: ISignServices.GetAuthorizedClient()


## Link
- https://developers.hellosign.com/api/quickstart/
- https://www.dropbox.com/developers/apps
- API key: https://app.hellosign.com/home/myAccount?current_tab=integrations#api
-https://documenter.getpostman.com/view/5021038/S17ru7ui#4a1fd627-6b3e-4ea1-b9eb-215a4967f604
- Document: https://dropbox.github.io/dropbox-sdk-dotnet/
- Postman collection : https://documenter.getpostman.com/view/5021038/S17ru7ui
