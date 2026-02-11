using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x0200000B RID: 11
	public class Achievement : Object
	{
		// Token: 0x06000076 RID: 118 RVA: 0x000038D0 File Offset: 0x00001AD0
		// Note: this type is marked as 'beforefieldinit'.
		static Achievement()
		{
			Il2CppClassPointerStore<Achievement>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.GameCenterModule.dll", "UnityEngine.SocialPlatforms.Impl", "Achievement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Achievement>.NativeClassPtr);
			Achievement.NativeFieldInfoPtr_m_Completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "m_Completed");
			Achievement.NativeFieldInfoPtr_m_Hidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "m_Hidden");
			Achievement.NativeFieldInfoPtr_m_LastReportedDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "m_LastReportedDate");
			Achievement.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "<id>k__BackingField");
			Achievement.NativeFieldInfoPtr__percentCompleted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "<percentCompleted>k__BackingField");
			Achievement.NativeMethodInfoPtr__ctor_Public_Void_String_Double_Boolean_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100663321);
			Achievement.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100663322);
			Achievement.NativeMethodInfoPtr_SetCompleted_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100663323);
			Achievement.NativeMethodInfoPtr_SetHidden_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100663324);
			Achievement.NativeMethodInfoPtr_SetLastReportedDate_Public_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100663325);
			Achievement.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100663326);
			Achievement.NativeMethodInfoPtr_set_id_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100663327);
			Achievement.NativeMethodInfoPtr_get_percentCompleted_Public_Virtual_Final_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100663328);
			Achievement.NativeMethodInfoPtr_set_percentCompleted_Public_Virtual_Final_New_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100663329);
			Achievement.NativeMethodInfoPtr_get_completed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100663330);
			Achievement.NativeMethodInfoPtr_get_hidden_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100663331);
			Achievement.NativeMethodInfoPtr_get_lastReportedDate_Public_Virtual_Final_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100663332);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003A54 File Offset: 0x00001C54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1270761, RefRangeEnd = 1270762, XrefRangeStart = 1270759, XrefRangeEnd = 1270761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Achievement(string id, double percentCompleted, bool completed, bool hidden, DateTime lastReportedDate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Achievement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percentCompleted;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref completed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hidden;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastReportedDate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr__ctor_Public_Void_String_Double_Boolean_Boolean_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003AD8 File Offset: 0x00001CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270762, XrefRangeEnd = 1270790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Achievement.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003B1C File Offset: 0x00001D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCompleted(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_SetCompleted_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003B5C File Offset: 0x00001D5C
		[CallerCount(0)]
		public unsafe void SetHidden(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_SetHidden_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003B9C File Offset: 0x00001D9C
		[CallerCount(0)]
		public unsafe void SetLastReportedDate(DateTime date)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref date;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_SetLastReportedDate_Public_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003BDC File Offset: 0x00001DDC
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00003C14 File Offset: 0x00001E14
		public unsafe virtual string id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_set_id_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00003C58 File Offset: 0x00001E58
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00003C94 File Offset: 0x00001E94
		public unsafe virtual double percentCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_get_percentCompleted_Public_Virtual_Final_New_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_set_percentCompleted_Public_Virtual_Final_New_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003CD4 File Offset: 0x00001ED4
		public unsafe virtual bool completed
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1101036, RefRangeEnd = 1101038, XrefRangeStart = 1101036, XrefRangeEnd = 1101038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_get_completed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00003D10 File Offset: 0x00001F10
		public unsafe virtual bool hidden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_get_hidden_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003D4C File Offset: 0x00001F4C
		public unsafe virtual DateTime lastReportedDate
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 318167, RefRangeEnd = 318212, XrefRangeStart = 318167, XrefRangeEnd = 318212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_get_lastReportedDate_Public_Virtual_Final_New_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002439 File Offset: 0x00000639
		public Achievement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00003D88 File Offset: 0x00001F88
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002442 File Offset: 0x00000642
		public unsafe bool m_Completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.NativeFieldInfoPtr_m_Completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.NativeFieldInfoPtr_m_Completed)) = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003DB0 File Offset: 0x00001FB0
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0000245D File Offset: 0x0000065D
		public unsafe bool m_Hidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.NativeFieldInfoPtr_m_Hidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.NativeFieldInfoPtr_m_Hidden)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003DD8 File Offset: 0x00001FD8
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002478 File Offset: 0x00000678
		public unsafe DateTime m_LastReportedDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.NativeFieldInfoPtr_m_LastReportedDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.NativeFieldInfoPtr_m_LastReportedDate)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00003E00 File Offset: 0x00002000
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002493 File Offset: 0x00000693
		public unsafe string _id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.NativeFieldInfoPtr__id_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.NativeFieldInfoPtr__id_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00003E28 File Offset: 0x00002028
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000024B2 File Offset: 0x000006B2
		public unsafe double _percentCompleted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.NativeFieldInfoPtr__percentCompleted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.NativeFieldInfoPtr__percentCompleted_k__BackingField)) = value;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000024CD File Offset: 0x000006CD
		public void ReportProgress(Action<bool> callback)
		{
			ActivePlatform.Instance.ReportProgress(this.id, this.percentCompleted, callback);
		}

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_m_Completed;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_m_Hidden;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_m_LastReportedDate;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr__percentCompleted_k__BackingField;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Double_Boolean_Boolean_DateTime_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_SetCompleted_Public_Void_Boolean_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_SetHidden_Public_Void_Boolean_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_SetLastReportedDate_Public_Void_DateTime_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_percentCompleted_Public_Virtual_Final_New_get_Double_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_set_percentCompleted_Public_Virtual_Final_New_set_Void_Double_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_get_completed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_hidden_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_get_lastReportedDate_Public_Virtual_Final_New_get_DateTime_0;
	}
}
