using System;
using analytics;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace zen.analytics
{
	// Token: 0x0200008D RID: 141
	public class StandardAnalyticsMessage : IAnalyticsMessage
	{
		// Token: 0x06000708 RID: 1800 RVA: 0x0002702C File Offset: 0x0002522C
		// Note: this type is marked as 'beforefieldinit'.
		static StandardAnalyticsMessage()
		{
			Il2CppClassPointerStore<StandardAnalyticsMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics", "StandardAnalyticsMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardAnalyticsMessage>.NativeClassPtr);
			StandardAnalyticsMessage.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardAnalyticsMessage>.NativeClassPtr, "data");
			StandardAnalyticsMessage.NativeMethodInfoPtr_get_eventName_Protected_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardAnalyticsMessage>.NativeClassPtr, 100664442);
			StandardAnalyticsMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardAnalyticsMessage>.NativeClassPtr, 100664443);
			StandardAnalyticsMessage.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardAnalyticsMessage>.NativeClassPtr, 100664444);
			StandardAnalyticsMessage.NativeMethodInfoPtr_updateData_Protected_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardAnalyticsMessage>.NativeClassPtr, 100664445);
			StandardAnalyticsMessage.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardAnalyticsMessage>.NativeClassPtr, 100664446);
			StandardAnalyticsMessage.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardAnalyticsMessage>.NativeClassPtr, 100664447);
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x000270E8 File Offset: 0x000252E8
		public unsafe virtual string eventName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardAnalyticsMessage.NativeMethodInfoPtr_get_eventName_Protected_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0002712C File Offset: 0x0002532C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandardAnalyticsMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardAnalyticsMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardAnalyticsMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00027168 File Offset: 0x00025368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 989813, RefRangeEnd = 989814, XrefRangeStart = 989750, XrefRangeEnd = 989813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandardAnalyticsMessage(Dictionary<string, Object> d, string g)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardAnalyticsMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(g);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardAnalyticsMessage.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000271C8 File Offset: 0x000253C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 989837, RefRangeEnd = 989838, XrefRangeStart = 989814, XrefRangeEnd = 989837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateData(Dictionary<string, Object> d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardAnalyticsMessage.NativeMethodInfoPtr_updateData_Protected_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0002720C File Offset: 0x0002540C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989838, XrefRangeEnd = 989842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string url(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardAnalyticsMessage.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00027260 File Offset: 0x00025460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989842, XrefRangeEnd = 989845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string body(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardAnalyticsMessage.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00005241 File Offset: 0x00003441
		public StandardAnalyticsMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x000272B4 File Offset: 0x000254B4
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x0000524A File Offset: 0x0000344A
		public unsafe Dictionary<string, Object> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardAnalyticsMessage.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardAnalyticsMessage.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_get_eventName_Protected_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_String_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_updateData_Protected_Void_Dictionary_2_String_Object_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0;

		// Token: 0x02000212 RID: 530
		[ObfuscatedName("zen.analytics.StandardAnalyticsMessage+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06001851 RID: 6225 RVA: 0x0005C808 File Offset: 0x0005AA08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<StandardAnalyticsMessage.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StandardAnalyticsMessage>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardAnalyticsMessage.__c__DisplayClass4_0>.NativeClassPtr);
				StandardAnalyticsMessage.__c__DisplayClass4_0.NativeFieldInfoPtr_initialValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardAnalyticsMessage.__c__DisplayClass4_0>.NativeClassPtr, "initialValues");
				StandardAnalyticsMessage.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardAnalyticsMessage.__c__DisplayClass4_0>.NativeClassPtr, 100664448);
				StandardAnalyticsMessage.__c__DisplayClass4_0.NativeMethodInfoPtr___ctor_b__0_Internal_Void_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardAnalyticsMessage.__c__DisplayClass4_0>.NativeClassPtr, 100664449);
			}

			// Token: 0x06001852 RID: 6226 RVA: 0x0005C870 File Offset: 0x0005AA70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardAnalyticsMessage.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardAnalyticsMessage.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001853 RID: 6227 RVA: 0x0005C8AC File Offset: 0x0005AAAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989744, XrefRangeEnd = 989750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__0(KeyValuePair<string, Object> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardAnalyticsMessage.__c__DisplayClass4_0.NativeMethodInfoPtr___ctor_b__0_Internal_Void_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001854 RID: 6228 RVA: 0x0000D503 File Offset: 0x0000B703
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000700 RID: 1792
			// (get) Token: 0x06001855 RID: 6229 RVA: 0x0005C8F4 File Offset: 0x0005AAF4
			// (set) Token: 0x06001856 RID: 6230 RVA: 0x0000D50C File Offset: 0x0000B70C
			public unsafe Dictionary<string, Object> initialValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardAnalyticsMessage.__c__DisplayClass4_0.NativeFieldInfoPtr_initialValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardAnalyticsMessage.__c__DisplayClass4_0.NativeFieldInfoPtr_initialValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000EBD RID: 3773
			private static readonly IntPtr NativeFieldInfoPtr_initialValues;

			// Token: 0x04000EBE RID: 3774
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000EBF RID: 3775
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_Void_KeyValuePair_2_String_Object_0;
		}
	}
}
