using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C2 RID: 194
	public class JsonSelectSettings : Object
	{
		// Token: 0x06001187 RID: 4487 RVA: 0x00061FAC File Offset: 0x000601AC
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSelectSettings()
		{
			Il2CppClassPointerStore<JsonSelectSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JsonSelectSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSelectSettings>.NativeClassPtr);
			JsonSelectSettings.NativeFieldInfoPtr__RegexMatchTimeout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSelectSettings>.NativeClassPtr, "<RegexMatchTimeout>k__BackingField");
			JsonSelectSettings.NativeFieldInfoPtr__ErrorWhenNoMatch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSelectSettings>.NativeClassPtr, "<ErrorWhenNoMatch>k__BackingField");
			JsonSelectSettings.NativeMethodInfoPtr_get_RegexMatchTimeout_Public_get_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSelectSettings>.NativeClassPtr, 100666532);
			JsonSelectSettings.NativeMethodInfoPtr_set_RegexMatchTimeout_Public_set_Void_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSelectSettings>.NativeClassPtr, 100666533);
			JsonSelectSettings.NativeMethodInfoPtr_get_ErrorWhenNoMatch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSelectSettings>.NativeClassPtr, 100666534);
			JsonSelectSettings.NativeMethodInfoPtr_set_ErrorWhenNoMatch_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSelectSettings>.NativeClassPtr, 100666535);
			JsonSelectSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSelectSettings>.NativeClassPtr, 100666536);
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x00062068 File Offset: 0x00060268
		// (set) Token: 0x06001189 RID: 4489 RVA: 0x000620A0 File Offset: 0x000602A0
		public unsafe Nullable<TimeSpan> RegexMatchTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSelectSettings.NativeMethodInfoPtr_get_RegexMatchTimeout_Public_get_Nullable_1_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<TimeSpan>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSelectSettings.NativeMethodInfoPtr_set_RegexMatchTimeout_Public_set_Void_Nullable_1_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x000620E8 File Offset: 0x000602E8
		// (set) Token: 0x0600118B RID: 4491 RVA: 0x00062124 File Offset: 0x00060324
		public unsafe bool ErrorWhenNoMatch
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSelectSettings.NativeMethodInfoPtr_get_ErrorWhenNoMatch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSelectSettings.NativeMethodInfoPtr_set_ErrorWhenNoMatch_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00062164 File Offset: 0x00060364
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSelectSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSelectSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSelectSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x000079E4 File Offset: 0x00005BE4
		public JsonSelectSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x000621A0 File Offset: 0x000603A0
		// (set) Token: 0x0600118F RID: 4495 RVA: 0x000079ED File Offset: 0x00005BED
		public Nullable<TimeSpan> _RegexMatchTimeout_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSelectSettings.NativeFieldInfoPtr__RegexMatchTimeout_k__BackingField);
				return new Nullable<TimeSpan>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSelectSettings.NativeFieldInfoPtr__RegexMatchTimeout_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TimeSpan>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x000621D0 File Offset: 0x000603D0
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x00007A1B File Offset: 0x00005C1B
		public unsafe bool _ErrorWhenNoMatch_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSelectSettings.NativeFieldInfoPtr__ErrorWhenNoMatch_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSelectSettings.NativeFieldInfoPtr__ErrorWhenNoMatch_k__BackingField)) = value;
			}
		}

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeFieldInfoPtr__RegexMatchTimeout_k__BackingField;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeFieldInfoPtr__ErrorWhenNoMatch_k__BackingField;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr_get_RegexMatchTimeout_Public_get_Nullable_1_TimeSpan_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_set_RegexMatchTimeout_Public_set_Void_Nullable_1_TimeSpan_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorWhenNoMatch_Public_get_Boolean_0;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorWhenNoMatch_Public_set_Void_Boolean_0;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
