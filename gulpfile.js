var gulp = require('gulp');
var sass = require('gulp-sass');
var prefix = require('gulp-autoprefixer');
var rename = require('gulp-rename');
var cssmin = require('gulp-cssmin');
var watch = require('gulp-watch');
var imageop = require('gulp-image-optimization');
var concat = require('gulp-concat');
var uglify = require('gulp-uglifyjs');
var browserSync = require('browser-sync');
var notify = require('gulp-notify');
var reload = browserSync.reload;

gulp.task('html', function(){
    gulp.src('**/*.html')
    .pipe(reload({stream:true}))
});

/* trocar o empty pelo repositorio atual */
gulp.task('browser-sync', function() {
    browserSync.init({
        notify:false,
        proxy : 'http://localhost/randon-campo/',
    });
});



gulp.task('images', function(cb) {
    gulp.src(['./_dev/images/**/*.png','./_dev/images/**/*.jpg','./_dev/images/**/*.gif','./_dev/images/**/*.jpeg']).pipe(imageop({
        optimizationLevel: 10,
        progressive: true,
        interlaced: true
    })).pipe(gulp.dest('./_assets/images')).on('end', cb).on('error', cb);
});

gulp.task('watch', ['browser-sync'], function(){
    gulp.watch('./_dev/sass/**/*.scss', ['style']);
    gulp.watch('./_assets/css/**/*.css',  browserSync.reload);
    gulp.watch('./_dev/js/**/*.js', ['scripts']);
    gulp.watch('./_assets/js/**/*.js',  browserSync.reload);
    gulp.watch('**/*.html', browserSync.reload);
});
 
 
/* Styles */
gulp.task('style', function(){
    gulp.src('./_dev/sass/**/*.scss')
        .pipe(sass())
        .on('error', notify.onError(function (error) {
           return 'An error occurred while compiling sass.\nLook in the console for details.\n' + error;
        }))
        .pipe(prefix({
            browsers:  ['IE 8', 'IE 9', 'last 5 versions', 'Firefox 14', 'Opera 11.1'],
            cascade: false
        }))
        .pipe(cssmin())
        .pipe(rename({suffix: '.min'}))
        .pipe(gulp.dest('./_assets/css'))
        .pipe(notify({ message: 'Style task complete' }));
});

gulp.task('fonts', function () {
    return gulp.src('./_dev/fonts/**/*.*')
        .pipe(gulp.dest('./_assets/css/fonts'));
}); 


/* Deploy */
gulp.task('deploy', function(){});


/* Scripts */
gulp.task('scripts', function() {
  gulp.src(['./_dev/js/plugins.js', './_dev/js/main.js'])
    .pipe(concat('all.js'))
    .pipe(uglify())
    .on('error', notify.onError(function (error) {
       return 'An error occurred while compiling sass.\nLook in the console for details.\n' + error;
    }))
    .pipe(gulp.dest('./_assets/js'))
    .pipe(notify({ message: 'Scripts task complete' }));
});
 

 
/* Default */
gulp.task('default', ['style', 'scripts', 'watch',  'browser-sync']);