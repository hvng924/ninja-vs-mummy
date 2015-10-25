//
//  ShareController.m
//  UnitySharePlugin
//
//  Created by Phuong NT on 10/25/15.
//  Copyright © 2015 hung NV. All rights reserved.
//

#import "ShareController.h"

@interface ShareController ()

@end

@implementation ShareController

-(void) shareImage: (const char*) imgPath
{
    NSString *imagePath = [NSString stringWithUTF8String:imgPath];
    UIImage *image = [UIImage imageWithContentsOfFile:imagePath];
    UIActivityViewController *activityVc = [[UIActivityViewController alloc] initWithActivityItems:@[image] applicationActivities:nil];
    [[UIApplication sharedApplication].keyWindow.rootViewController presentViewController:activityVc
                                                                                   animated:YES
                                                                                 completion:nil];
}

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/

@end

extern "C"
{
    void shareImageIphone(const char* imgPath)
    {
        ShareController *vc = [[ShareController alloc] init];
        [vc shareImage:imgPath];
    }
}
