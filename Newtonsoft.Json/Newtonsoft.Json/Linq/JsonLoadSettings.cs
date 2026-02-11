using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C0 RID: 192
	public class JsonLoadSettings : Object
	{
		// Token: 0x06001169 RID: 4457 RVA: 0x0006196C File Offset: 0x0005FB6C
		// Note: this type is marked as 'beforefieldinit'.
		static JsonLoadSettings()
		{
			Il2CppClassPointerStore<JsonLoadSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JsonLoadSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonLoadSettings>.NativeClassPtr);
			JsonLoadSettings.NativeFieldInfoPtr__commentHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonLoadSettings>.NativeClassPtr, "_commentHandling");
			JsonLoadSettings.NativeFieldInfoPtr__lineInfoHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonLoadSettings>.NativeClassPtr, "_lineInfoHandling");
			JsonLoadSettings.NativeFieldInfoPtr__duplicatePropertyNameHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonLoadSettings>.NativeClassPtr, "_duplicatePropertyNameHandling");
			JsonLoadSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonLoadSettings>.NativeClassPtr, 100666518);
			JsonLoadSettings.NativeMethodInfoPtr_get_CommentHandling_Public_get_CommentHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonLoadSettings>.NativeClassPtr, 100666519);
			JsonLoadSettings.NativeMethodInfoPtr_set_CommentHandling_Public_set_Void_CommentHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonLoadSettings>.NativeClassPtr, 100666520);
			JsonLoadSettings.NativeMethodInfoPtr_get_LineInfoHandling_Public_get_LineInfoHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonLoadSettings>.NativeClassPtr, 100666521);
			JsonLoadSettings.NativeMethodInfoPtr_set_LineInfoHandling_Public_set_Void_LineInfoHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonLoadSettings>.NativeClassPtr, 100666522);
			JsonLoadSettings.NativeMethodInfoPtr_get_DuplicatePropertyNameHandling_Public_get_DuplicatePropertyNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonLoadSettings>.NativeClassPtr, 100666523);
			JsonLoadSettings.NativeMethodInfoPtr_set_DuplicatePropertyNameHandling_Public_set_Void_DuplicatePropertyNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonLoadSettings>.NativeClassPtr, 100666524);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00061A64 File Offset: 0x0005FC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759261, XrefRangeEnd = 759262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonLoadSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonLoadSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonLoadSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x00061AA0 File Offset: 0x0005FCA0
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x00061ADC File Offset: 0x0005FCDC
		public unsafe CommentHandling CommentHandling
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonLoadSettings.NativeMethodInfoPtr_get_CommentHandling_Public_get_CommentHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonLoadSettings.NativeMethodInfoPtr_set_CommentHandling_Public_set_Void_CommentHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x00061B1C File Offset: 0x0005FD1C
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x00061B58 File Offset: 0x0005FD58
		public unsafe LineInfoHandling LineInfoHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonLoadSettings.NativeMethodInfoPtr_get_LineInfoHandling_Public_get_LineInfoHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonLoadSettings.NativeMethodInfoPtr_set_LineInfoHandling_Public_set_Void_LineInfoHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x00061B98 File Offset: 0x0005FD98
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x00061BD4 File Offset: 0x0005FDD4
		public unsafe DuplicatePropertyNameHandling DuplicatePropertyNameHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonLoadSettings.NativeMethodInfoPtr_get_DuplicatePropertyNameHandling_Public_get_DuplicatePropertyNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonLoadSettings.NativeMethodInfoPtr_set_DuplicatePropertyNameHandling_Public_set_Void_DuplicatePropertyNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00007930 File Offset: 0x00005B30
		public JsonLoadSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x00061C14 File Offset: 0x0005FE14
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x00007939 File Offset: 0x00005B39
		public unsafe CommentHandling _commentHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonLoadSettings.NativeFieldInfoPtr__commentHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonLoadSettings.NativeFieldInfoPtr__commentHandling)) = value;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x00061C3C File Offset: 0x0005FE3C
		// (set) Token: 0x06001175 RID: 4469 RVA: 0x00007954 File Offset: 0x00005B54
		public unsafe LineInfoHandling _lineInfoHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonLoadSettings.NativeFieldInfoPtr__lineInfoHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonLoadSettings.NativeFieldInfoPtr__lineInfoHandling)) = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x00061C64 File Offset: 0x0005FE64
		// (set) Token: 0x06001177 RID: 4471 RVA: 0x0000796F File Offset: 0x00005B6F
		public unsafe DuplicatePropertyNameHandling _duplicatePropertyNameHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonLoadSettings.NativeFieldInfoPtr__duplicatePropertyNameHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonLoadSettings.NativeFieldInfoPtr__duplicatePropertyNameHandling)) = value;
			}
		}

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeFieldInfoPtr__commentHandling;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeFieldInfoPtr__lineInfoHandling;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeFieldInfoPtr__duplicatePropertyNameHandling;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_get_CommentHandling_Public_get_CommentHandling_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_set_CommentHandling_Public_set_Void_CommentHandling_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_get_LineInfoHandling_Public_get_LineInfoHandling_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr_set_LineInfoHandling_Public_set_Void_LineInfoHandling_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_get_DuplicatePropertyNameHandling_Public_get_DuplicatePropertyNameHandling_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_set_DuplicatePropertyNameHandling_Public_set_Void_DuplicatePropertyNameHandling_0;
	}
}
