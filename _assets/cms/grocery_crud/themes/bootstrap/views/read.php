<?php
$this->set_css($this->default_theme_path.'/bootstrap/css/bootstrap/bootstrap.min.css');
$this->set_css($this->default_theme_path.'/bootstrap/css/font-awesome/css/font-awesome.min.css');
$this->set_css($this->default_theme_path.'/bootstrap/css/common.css');
$this->set_css($this->default_theme_path.'/bootstrap/css/general.css');
$this->set_css($this->default_theme_path.'/bootstrap/css/add-edit-form.css');

$this->set_js_lib($this->default_javascript_path.'/'.grocery_CRUD::JQUERY);
$this->set_js_lib($this->default_theme_path. '/bootstrap/js/jquery-ui/jquery-ui.custom.min.js');
$this->set_js_lib($this->default_theme_path.'/bootstrap/js/jquery-plugins/jquery.form.min.js');
$this->set_js_lib($this->default_theme_path.'/bootstrap/js/common/common.min.js');

$this->set_js_config($this->default_theme_path.'/bootstrap/js/form/view.js');
?>
<div class="page-header">
    <ol class="breadcrumb">
        <li><?php echo $subject?></li>
        <li class="active"><?php echo $this->l('list_view'); ?> <?php echo $subject?></li>
    </ol>
</div>
<div class="crud-form" data-unique-hash="<?php echo $unique_hash; ?>">
        <div class="row">
            <div class="col-md-12">
                <div class="form-container table-container">
                    <?php echo form_open( $update_url, 'method="post" id="crudForm"  enctype="multipart/form-data" class="form-horizontal"'); ?>

                    <?php foreach($fields as $field) { ?>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                <?php echo $input_fields[$field->field_name]->display_as?>:
                            </label>
                            <div class="col-sm-10 read-row">
                                <?php echo $input_fields[$field->field_name]->input; ?>
                            </div>
                        </div>
                    <?php }?>

                    <?php if(!empty($hidden_fields)){?>
                        <!-- Start of hidden inputs -->
                        <?php
                        foreach($hidden_fields as $hidden_field){
                            echo $hidden_field->input;
                        }
                        ?>
                        <!-- End of hidden inputs -->
                    <?php } ?>
                    <?php if ($is_ajax) { ?><input type="hidden" name="is_ajax" value="true" /><?php }?>
                    <div id='report-error' class='report-div error'></div>
                    <div id='report-success' class='report-div success'></div>

                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <?php 	if(!$this->unset_back_to_list) { ?>
                                <button class="btn btn-default cancel-button" type="button" onclick="window.location = '<?php echo $list_url; ?>'" >
                                    <i class="fa fa-arrow-left"></i>
                                    <?php echo $this->l('form_back_to_list'); ?>
                                </button>
                            <?php } ?>
                        </div>
                    </div>
                    <?php echo form_close(); ?>
                </div>
            </div>
        </div>
</div>
<script>
    var validation_url = '<?php echo $validation_url?>';
    var list_url = '<?php echo $list_url?>';

    var message_alert_edit_form = "<?php echo $this->l('alert_edit_form')?>";
    var message_update_error = "<?php echo $this->l('update_error')?>";
</script>