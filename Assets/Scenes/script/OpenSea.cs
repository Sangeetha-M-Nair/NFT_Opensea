// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
using System;
using System.Collections.Generic;

[Serializable]
public class Asset
    {
        public int id;
        public int num_sales;
        public string background_color;
        public string image_url;
        public string image_preview_url;
        public string image_thumbnail_url;
        public string image_original_url;
        public object animation_url;
        public object animation_original_url;
        public string name;
        public string description;
        public string external_link;
        public AssetContract asset_contract;
        public string permalink;
        public Collection collection;
        public object decimals;
        public string token_metadata;
        public bool is_nsfw;
        public Owner owner;
        public object seaport_sell_orders;
        public Creator creator;
        public List<Trait> traits;
        public object last_sale;
        public object top_bid;
        public object listing_date;
        public bool is_presale;
        public object transfer_fee_payment_token;
        public object transfer_fee;
        public object rarity_data;
        public string token_id;
    }

    public class AssetContract
    {
        public string address;
        public string asset_contract_type;
        public DateTime created_date;
        public string name;
        public string nft_version;
        public string opensea_version;
        public int? owner;
        public string schema_name;
        public string symbol;
        public string total_supply;
        public string description;
        public object external_link;
        public object image_url;
        public bool default_to_fiat;
        public int dev_buyer_fee_basis_points;
        public int dev_seller_fee_basis_points;
        public bool only_proxied_transfers;
        public int opensea_buyer_fee_basis_points;
        public int opensea_seller_fee_basis_points;
        public int buyer_fee_basis_points;
        public int seller_fee_basis_points;
        public string payout_address;
        public Fees fees;
    }

    public class Collection
    {
        public object banner_image_url;
        public object chat_url;
        public DateTime created_date;
        public bool default_to_fiat;
        public string description;
        public string dev_buyer_fee_basis_points;
        public string dev_seller_fee_basis_points;
        public object discord_url;
        public DisplayData display_data;
        public object external_url;
        public bool featured;
        public object featured_image_url;
        public bool hidden;
        public string safelist_request_status;
        public object image_url;
        public bool is_subject_to_whitelist;
        public object large_image_url;
        public object medium_username;
        public string name;
        public bool only_proxied_transfers;
        public string opensea_buyer_fee_basis_points;
        public string opensea_seller_fee_basis_points;
        public string payout_address;
        public bool require_email;
        public object short_description;
        public string slug;
        public object telegram_url;
        public object twitter_username;
        public object instagram_username;
        public object wiki_url;
        public bool is_nsfw;
        public bool is_rarity_enabled;
        public Fees fees;
    }

    public class Creator
    {
        public User user;
        public string profile_img_url;
        public string address;
        public string config;
    }

    public class DisplayData
    {
        public string card_display_style;
        public List<object> images;
    }

    public class Fees
    {
        public SellerFees seller_fees;
        public OpenseaFees opensea_fees;
    }

    public class OpenseaFees
    {
        public int _0x0000a26b00c1f0df003000390027140000faa719;
    }

    public class Owner
    {
        public User user;
        public string profile_img_url;
        public string address;
        public string config;
    }

    public class Root
    {
        public List<Asset> assets;
    }

    public class SellerFees
    {
        public int? _0x000000000000000000000000000000000000dead;
    }

    public class Trait
    {
        public string trait_type;
        public object value;
        public string display_type;
        public object max_value;
        public int trait_count;
        public object order;
    }

    public class User
    {
        public string username;
    }

[Serializable]
public class OpenSea
{
    public List<Asset> assets;
}