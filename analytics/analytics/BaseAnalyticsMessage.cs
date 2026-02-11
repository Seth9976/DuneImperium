using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace analytics
{
	// Token: 0x02000008 RID: 8
	public class BaseAnalyticsMessage : IAnalyticsMessage
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002944 File Offset: 0x00000B44
		// Note: this type is marked as 'beforefieldinit'.
		static BaseAnalyticsMessage()
		{
			Il2CppClassPointerStore<BaseAnalyticsMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("analytics.dll", "analytics", "BaseAnalyticsMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseAnalyticsMessage>.NativeClassPtr);
			BaseAnalyticsMessage.NativeFieldInfoPtr_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseAnalyticsMessage>.NativeClassPtr, "eventName");
			BaseAnalyticsMessage.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseAnalyticsMessage>.NativeClassPtr, "data");
			BaseAnalyticsMessage.NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseAnalyticsMessage>.NativeClassPtr, 100663312);
			BaseAnalyticsMessage.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseAnalyticsMessage>.NativeClassPtr, 100663313);
			BaseAnalyticsMessage.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseAnalyticsMessage>.NativeClassPtr, 100663314);
			BaseAnalyticsMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseAnalyticsMessage>.NativeClassPtr, 100663315);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000029EC File Offset: 0x00000BEC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 410349, RefRangeEnd = 410363, XrefRangeStart = 410349, XrefRangeEnd = 410363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseAnalyticsMessage(string eventName, Dictionary<string, Object> dict)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseAnalyticsMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dict);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseAnalyticsMessage.NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002A4C File Offset: 0x00000C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273394, XrefRangeEnd = 1273398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string url(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseAnalyticsMessage.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002AA0 File Offset: 0x00000CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273420, RefRangeEnd = 1273421, XrefRangeStart = 1273398, XrefRangeEnd = 1273420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string body(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseAnalyticsMessage.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002AF4 File Offset: 0x00000CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273421, XrefRangeEnd = 1273447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseAnalyticsMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000210B File Offset: 0x0000030B
		public BaseAnalyticsMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002B38 File Offset: 0x00000D38
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002114 File Offset: 0x00000314
		public unsafe string eventName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseAnalyticsMessage.NativeFieldInfoPtr_eventName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseAnalyticsMessage.NativeFieldInfoPtr_eventName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002B60 File Offset: 0x00000D60
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002133 File Offset: 0x00000333
		public unsafe Dictionary<string, Object> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseAnalyticsMessage.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseAnalyticsMessage.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_eventName;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_Object_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0200000E RID: 14
		[ObfuscatedName("analytics.BaseAnalyticsMessage+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000051 RID: 81 RVA: 0x00003284 File Offset: 0x00001484
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BaseAnalyticsMessage.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseAnalyticsMessage>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseAnalyticsMessage.__c>.NativeClassPtr);
				BaseAnalyticsMessage.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseAnalyticsMessage.__c>.NativeClassPtr, "<>9");
				BaseAnalyticsMessage.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseAnalyticsMessage.__c>.NativeClassPtr, "<>9__5_0");
				BaseAnalyticsMessage.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseAnalyticsMessage.__c>.NativeClassPtr, 100663317);
				BaseAnalyticsMessage.__c.NativeMethodInfoPtr__ToString_b__5_0_Internal_String_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseAnalyticsMessage.__c>.NativeClassPtr, 100663318);
			}

			// Token: 0x06000052 RID: 82 RVA: 0x00003300 File Offset: 0x00001500
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseAnalyticsMessage.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseAnalyticsMessage.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000053 RID: 83 RVA: 0x0000333C File Offset: 0x0000153C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273382, XrefRangeEnd = 1273394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__5_0(KeyValuePair<string, Object> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseAnalyticsMessage.__c.NativeMethodInfoPtr__ToString_b__5_0_Internal_String_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000054 RID: 84 RVA: 0x0000223C File Offset: 0x0000043C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000055 RID: 85 RVA: 0x0000338C File Offset: 0x0000158C
			// (set) Token: 0x06000056 RID: 86 RVA: 0x00002245 File Offset: 0x00000445
			public unsafe static BaseAnalyticsMessage.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BaseAnalyticsMessage.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseAnalyticsMessage.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BaseAnalyticsMessage.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000057 RID: 87 RVA: 0x000033B4 File Offset: 0x000015B4
			// (set) Token: 0x06000058 RID: 88 RVA: 0x00002257 File Offset: 0x00000457
			public unsafe static Func<KeyValuePair<string, Object>, string> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BaseAnalyticsMessage.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Object>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BaseAnalyticsMessage.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400002C RID: 44
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400002D RID: 45
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400002E RID: 46
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400002F RID: 47
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__5_0_Internal_String_KeyValuePair_2_String_Object_0;
		}
	}
}
