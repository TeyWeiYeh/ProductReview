namespace ProductReview.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string ProductsEndpoint = $"{Prefix}/products";
        public static readonly string NewsEndpoint = $"{Prefix}/news";
        public static readonly string ReviewsEndpoint = $"{Prefix}/reviews";
        public static readonly string CategoriesEndpoint = $"{Prefix}/categories";
        public static readonly string CommentsEndpoint = $"{Prefix}/comments";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string FavouritesEndpoint = $"{Prefix}/favourites";
        public static readonly string LinksEndpoint = $"{Prefix}/links";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string BrandsEndpoint = $"{Prefix}/brands";

    }
}
