﻿// <auto-generated />
using System;
using ConsoleApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Bpmtk.Engine.Models.ActivityInstance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnName("activity_id")
                        .HasMaxLength(64);

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasColumnName("activity_type")
                        .HasMaxLength(16);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("concurrency_stamp")
                        .HasMaxLength(50);

                    b.Property<DateTime>("Created")
                        .HasColumnName("created");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<bool>("IsMIRoot")
                        .HasColumnName("is_mi_root");

                    b.Property<DateTime>("LastStateTime")
                        .HasColumnName("last_state_time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.Property<long?>("ParentId")
                        .HasColumnName("parent_id");

                    b.Property<long?>("ProcessInstanceId")
                        .HasColumnName("proc_inst_id");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnName("start_time");

                    b.Property<int>("State")
                        .HasColumnName("state");

                    b.Property<long?>("SubProcessInstanceId")
                        .HasColumnName("sub_proc_inst_id");

                    b.Property<long?>("TokenId")
                        .IsRequired()
                        .HasColumnName("token_id");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("ProcessInstanceId");

                    b.HasIndex("SubProcessInstanceId");

                    b.ToTable("bpm_act_inst");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.ActivityVariable", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long?>("ActivityInstanceId")
                        .HasColumnName("act_inst_id");

                    b.Property<long?>("ByteArrayId")
                        .HasColumnName("byte_array_id");

                    b.Property<double?>("DoubleValue")
                        .HasColumnName("double_val");

                    b.Property<long?>("LongValue")
                        .HasColumnName("long_val");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(64);

                    b.Property<string>("Text")
                        .HasColumnName("text");

                    b.Property<string>("Text2")
                        .HasColumnName("text2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("ActivityInstanceId");

                    b.HasIndex("ByteArrayId");

                    b.ToTable("bpm_act_data");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.ByteArray", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<byte[]>("Value")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.ToTable("bpm_byte_array");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnName("body")
                        .HasMaxLength(512);

                    b.Property<DateTime>("Created")
                        .HasColumnName("created");

                    b.Property<int?>("ProcessDefinitionId")
                        .HasColumnName("proc_def_id");

                    b.Property<long?>("ProcessInstanceId")
                        .HasColumnName("proc_inst_id");

                    b.Property<long?>("TaskId")
                        .HasColumnName("task_id");

                    b.Property<string>("UserId")
                        .HasColumnName("user_id")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("ProcessDefinitionId");

                    b.HasIndex("ProcessInstanceId");

                    b.HasIndex("TaskId");

                    b.ToTable("bpm_comment");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.Deployment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Category")
                        .HasColumnName("category")
                        .HasMaxLength(64);

                    b.Property<DateTime>("Created")
                        .HasColumnName("created");

                    b.Property<string>("Memo")
                        .HasColumnName("memo")
                        .HasMaxLength(255);

                    b.Property<long?>("ModelId")
                        .HasColumnName("model_id");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(50);

                    b.Property<int?>("PackageId")
                        .HasColumnName("package_id");

                    b.Property<string>("TenantId")
                        .HasColumnName("tenant_id");

                    b.Property<string>("UserId")
                        .HasColumnName("user_id")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.HasIndex("PackageId");

                    b.ToTable("bpm_deployment");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.EventSubscription", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<DateTime>("Created")
                        .HasColumnName("created");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnName("event_name")
                        .HasMaxLength(50);

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnName("event_type")
                        .HasMaxLength(50);

                    b.Property<int?>("ProcessDefinitionId")
                        .HasColumnName("proc_def_id");

                    b.Property<long?>("ProcessInstanceId")
                        .HasColumnName("proc_inst_id");

                    b.Property<string>("TenantId")
                        .HasColumnName("tenant_id");

                    b.Property<long?>("TokenId")
                        .HasColumnName("token_id");

                    b.HasKey("Id");

                    b.HasIndex("ProcessDefinitionId");

                    b.HasIndex("ProcessInstanceId");

                    b.HasIndex("TokenId");

                    b.ToTable("bpm_event_subscr");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.Group", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("bpm_group");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.IdentityLink", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long?>("ActivityInstanceId")
                        .HasColumnName("act_inst_id");

                    b.Property<DateTime>("Created")
                        .HasColumnName("created");

                    b.Property<string>("GroupId")
                        .HasColumnName("group_id");

                    b.Property<int?>("ProcessDefinitionId")
                        .HasColumnName("proc_def_id");

                    b.Property<long?>("ProcessInstanceId")
                        .HasColumnName("proc_inst_id");

                    b.Property<long?>("TaskId")
                        .HasColumnName("task_id");

                    b.Property<string>("Type")
                        .HasColumnName("type")
                        .HasMaxLength(50);

                    b.Property<string>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("ActivityInstanceId");

                    b.HasIndex("ProcessDefinitionId");

                    b.HasIndex("ProcessInstanceId");

                    b.HasIndex("TaskId");

                    b.ToTable("bpm_identity_link");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Category")
                        .HasColumnName("category");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("concurrency_stamp");

                    b.Property<DateTime>("Created")
                        .HasColumnName("created");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<DateTime>("Modified")
                        .HasColumnName("modified");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("OwnerId")
                        .HasColumnName("owner_id");

                    b.Property<long?>("SourceId")
                        .HasColumnName("source_id");

                    b.Property<string>("TenantId")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Version")
                        .HasColumnName("version");

                    b.HasKey("Id");

                    b.HasIndex("SourceId");

                    b.ToTable("bpm_package");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.ProcessDefinition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Category")
                        .HasColumnName("category")
                        .HasMaxLength(50);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("concurrency_stamp");

                    b.Property<DateTime>("Created")
                        .HasColumnName("created");

                    b.Property<int>("DeploymentId")
                        .HasColumnName("deployment_id");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(255);

                    b.Property<bool>("HasDiagram")
                        .HasColumnName("has_diagram");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnName("key")
                        .HasMaxLength(64);

                    b.Property<DateTime>("Modified")
                        .HasColumnName("modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.Property<int>("State")
                        .HasColumnName("state");

                    b.Property<string>("TenantId")
                        .HasColumnName("tenant_id")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("ValidFrom")
                        .HasColumnName("valid_from");

                    b.Property<DateTime?>("ValidTo")
                        .HasColumnName("valid_to");

                    b.Property<int>("Version")
                        .HasColumnName("version");

                    b.Property<string>("VersionTag")
                        .HasColumnName("version_tag")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("DeploymentId");

                    b.HasIndex("Key", "Version")
                        .IsUnique();

                    b.ToTable("bpm_proc_def");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.ProcessInstance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long?>("CallerId")
                        .HasColumnName("caller_id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("concurrency_stamp");

                    b.Property<DateTime>("Created")
                        .HasColumnName("created");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(255);

                    b.Property<string>("EndReason")
                        .HasColumnName("end_reason")
                        .HasMaxLength(255);

                    b.Property<string>("Initiator")
                        .HasColumnName("initiator")
                        .HasMaxLength(32);

                    b.Property<string>("Key")
                        .HasColumnName("key")
                        .HasMaxLength(32);

                    b.Property<DateTime>("LastStateTime")
                        .HasColumnName("last_state_time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.Property<int?>("ProcessDefinitionId")
                        .IsRequired()
                        .HasColumnName("proc_def_id");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnName("start_time");

                    b.Property<int>("State")
                        .HasColumnName("state");

                    b.Property<long?>("SuperId")
                        .HasColumnName("super_id");

                    b.Property<string>("TenantId")
                        .HasColumnName("tenant_id");

                    b.HasKey("Id");

                    b.HasIndex("CallerId");

                    b.HasIndex("ProcessDefinitionId");

                    b.HasIndex("SuperId");

                    b.ToTable("bpm_proc_inst");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.ScheduledJob", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ActivityId")
                        .HasColumnName("activity_id");

                    b.Property<DateTime>("Created")
                        .HasColumnName("created");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnName("due_date");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnName("end_date");

                    b.Property<string>("Handler")
                        .HasColumnName("handler");

                    b.Property<string>("Key")
                        .HasColumnName("key");

                    b.Property<string>("Message")
                        .HasColumnName("message");

                    b.Property<string>("Options")
                        .HasColumnName("options");

                    b.Property<int?>("ProcessDefinitionId")
                        .HasColumnName("proc_def_id");

                    b.Property<long?>("ProcessInstanceId")
                        .HasColumnName("proc_inst_id");

                    b.Property<int>("Retries")
                        .HasColumnName("retries");

                    b.Property<string>("StackTrace")
                        .HasColumnName("stack_trace");

                    b.Property<string>("TenantId")
                        .HasColumnName("tenant_id");

                    b.Property<long?>("TokenId")
                        .HasColumnName("token_id");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ProcessDefinitionId");

                    b.HasIndex("ProcessInstanceId");

                    b.HasIndex("TokenId");

                    b.ToTable("bpm_scheduled_job");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.TaskInstance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ActivityId")
                        .HasColumnName("activity_id")
                        .HasMaxLength(64);

                    b.Property<long?>("ActivityInstanceId")
                        .HasColumnName("act_inst_id");

                    b.Property<string>("Assignee")
                        .HasColumnName("assignee")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("ClaimedTime")
                        .HasColumnName("claimed_time");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("concurrency_stamp");

                    b.Property<DateTime>("Created")
                        .HasColumnName("created");

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnName("due_date");

                    b.Property<DateTime>("LastStateTime")
                        .HasColumnName("last_state_time");

                    b.Property<DateTime>("Modified")
                        .HasColumnName("modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.Property<short>("Priority")
                        .HasColumnName("priority");

                    b.Property<long?>("ProcessInstanceId")
                        .HasColumnName("proc_inst_id");

                    b.Property<int>("State")
                        .HasColumnName("state");

                    b.Property<long?>("TokenId")
                        .HasColumnName("token_id");

                    b.HasKey("Id");

                    b.HasIndex("ActivityInstanceId");

                    b.HasIndex("ProcessInstanceId");

                    b.HasIndex("TokenId");

                    b.ToTable("bpm_task");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.Token", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ActivityId")
                        .HasColumnName("activity_id")
                        .HasMaxLength(64);

                    b.Property<long?>("ActivityInstanceId")
                        .HasColumnName("act_inst_id");

                    b.Property<bool>("IsActive")
                        .HasColumnName("is_active");

                    b.Property<bool>("IsMIRoot")
                        .HasColumnName("is_mi_root");

                    b.Property<bool>("IsScope")
                        .HasColumnName("is_scope");

                    b.Property<bool>("IsSuspended")
                        .HasColumnName("is_suspended");

                    b.Property<long?>("ParentId")
                        .HasColumnName("parent_id");

                    b.Property<long?>("ProcessInstanceId")
                        .IsRequired()
                        .HasColumnName("proc_inst_id");

                    b.Property<long?>("SubProcessInstanceId")
                        .HasColumnName("sub_proc_inst_id");

                    b.Property<string>("TransitionId")
                        .HasColumnName("transition_id")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("ActivityInstanceId");

                    b.HasIndex("ParentId");

                    b.HasIndex("ProcessInstanceId");

                    b.HasIndex("SubProcessInstanceId");

                    b.ToTable("bpm_token");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("bpm_user");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.UserGroup", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnName("user_id");

                    b.Property<string>("GroupId")
                        .HasColumnName("group_id");

                    b.HasKey("UserId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("bpm_user_group");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.Variable", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long?>("ByteArrayId")
                        .HasColumnName("byte_array_id");

                    b.Property<double?>("DoubleValue")
                        .HasColumnName("double_val");

                    b.Property<long?>("LongValue")
                        .HasColumnName("long_val");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(64);

                    b.Property<long?>("ProcessInstanceId")
                        .HasColumnName("proc_inst_id");

                    b.Property<long?>("TaskInstanceId")
                        .HasColumnName("task_id");

                    b.Property<string>("Text")
                        .HasColumnName("text")
                        .HasMaxLength(4000);

                    b.Property<string>("Text2")
                        .HasColumnName("text2")
                        .HasMaxLength(4000);

                    b.Property<long?>("TokenId")
                        .HasColumnName("token_id");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("ByteArrayId");

                    b.HasIndex("ProcessInstanceId");

                    b.HasIndex("TaskInstanceId");

                    b.HasIndex("TokenId");

                    b.ToTable("bpm_proc_data");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.ActivityInstance", b =>
                {
                    b.HasOne("Bpmtk.Engine.Models.ActivityInstance", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.ProcessInstance", "ProcessInstance")
                        .WithMany()
                        .HasForeignKey("ProcessInstanceId");

                    b.HasOne("Bpmtk.Engine.Models.ProcessInstance", "SubProcessInstance")
                        .WithMany()
                        .HasForeignKey("SubProcessInstanceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.ActivityVariable", b =>
                {
                    b.HasOne("Bpmtk.Engine.Models.ActivityInstance")
                        .WithMany("Variables")
                        .HasForeignKey("ActivityInstanceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.ByteArray", "ByteArray")
                        .WithMany()
                        .HasForeignKey("ByteArrayId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.Comment", b =>
                {
                    b.HasOne("Bpmtk.Engine.Models.ProcessDefinition", "ProcessDefinition")
                        .WithMany()
                        .HasForeignKey("ProcessDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.ProcessInstance", "ProcessInstance")
                        .WithMany()
                        .HasForeignKey("ProcessInstanceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.TaskInstance", "Task")
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.Deployment", b =>
                {
                    b.HasOne("Bpmtk.Engine.Models.ByteArray", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Bpmtk.Engine.Models.Package", "Package")
                        .WithMany()
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.EventSubscription", b =>
                {
                    b.HasOne("Bpmtk.Engine.Models.ProcessDefinition", "ProcessDefinition")
                        .WithMany()
                        .HasForeignKey("ProcessDefinitionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Bpmtk.Engine.Models.ProcessInstance", "ProcessInstance")
                        .WithMany()
                        .HasForeignKey("ProcessInstanceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Bpmtk.Engine.Models.Token", "Token")
                        .WithMany()
                        .HasForeignKey("TokenId");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.IdentityLink", b =>
                {
                    b.HasOne("Bpmtk.Engine.Models.ActivityInstance")
                        .WithMany("IdentityLinks")
                        .HasForeignKey("ActivityInstanceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.ProcessDefinition", "ProcessDefinition")
                        .WithMany("IdentityLinks")
                        .HasForeignKey("ProcessDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.ProcessInstance", "ProcessInstance")
                        .WithMany("IdentityLinks")
                        .HasForeignKey("ProcessInstanceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.TaskInstance", "Task")
                        .WithMany("IdentityLinks")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.Package", b =>
                {
                    b.HasOne("Bpmtk.Engine.Models.ByteArray", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.ProcessDefinition", b =>
                {
                    b.HasOne("Bpmtk.Engine.Models.Deployment", "Deployment")
                        .WithMany("ProcessDefinitions")
                        .HasForeignKey("DeploymentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.ProcessInstance", b =>
                {
                    b.HasOne("Bpmtk.Engine.Models.ActivityInstance", "Caller")
                        .WithMany()
                        .HasForeignKey("CallerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.ProcessDefinition", "ProcessDefinition")
                        .WithMany()
                        .HasForeignKey("ProcessDefinitionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Bpmtk.Engine.Models.Token", "Super")
                        .WithMany()
                        .HasForeignKey("SuperId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.ScheduledJob", b =>
                {
                    b.HasOne("Bpmtk.Engine.Models.ProcessDefinition", "ProcessDefinition")
                        .WithMany()
                        .HasForeignKey("ProcessDefinitionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Bpmtk.Engine.Models.ProcessInstance", "ProcessInstance")
                        .WithMany()
                        .HasForeignKey("ProcessInstanceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Bpmtk.Engine.Models.Token", "Token")
                        .WithMany()
                        .HasForeignKey("TokenId");
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.TaskInstance", b =>
                {
                    b.HasOne("Bpmtk.Engine.Models.ActivityInstance", "ActivityInstance")
                        .WithMany()
                        .HasForeignKey("ActivityInstanceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.ProcessInstance", "ProcessInstance")
                        .WithMany()
                        .HasForeignKey("ProcessInstanceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.Token", "Token")
                        .WithMany()
                        .HasForeignKey("TokenId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.Token", b =>
                {
                    b.HasOne("Bpmtk.Engine.Models.ActivityInstance", "ActivityInstance")
                        .WithMany()
                        .HasForeignKey("ActivityInstanceId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Bpmtk.Engine.Models.Token", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.ProcessInstance", "ProcessInstance")
                        .WithMany("Tokens")
                        .HasForeignKey("ProcessInstanceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.ProcessInstance", "SubProcessInstance")
                        .WithMany()
                        .HasForeignKey("SubProcessInstanceId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.UserGroup", b =>
                {
                    b.HasOne("Bpmtk.Engine.Models.Group", "Group")
                        .WithMany("Users")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.User", "User")
                        .WithMany("Groups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bpmtk.Engine.Models.Variable", b =>
                {
                    b.HasOne("Bpmtk.Engine.Models.ByteArray", "ByteArray")
                        .WithMany()
                        .HasForeignKey("ByteArrayId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Bpmtk.Engine.Models.ProcessInstance", "ProcessInstance")
                        .WithMany("Variables")
                        .HasForeignKey("ProcessInstanceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.TaskInstance")
                        .WithMany("Variables")
                        .HasForeignKey("TaskInstanceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bpmtk.Engine.Models.Token")
                        .WithMany("Variables")
                        .HasForeignKey("TokenId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
