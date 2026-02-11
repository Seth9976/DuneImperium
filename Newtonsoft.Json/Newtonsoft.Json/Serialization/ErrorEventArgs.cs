using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000079 RID: 121
	public class ErrorEventArgs : EventArgs
	{
		// Token: 0x06000A41 RID: 2625 RVA: 0x00041DBC File Offset: 0x0003FFBC
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorEventArgs()
		{
			Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "ErrorEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr);
			ErrorEventArgs.NativeFieldInfoPtr__CurrentObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr, "<CurrentObject>k__BackingField");
			ErrorEventArgs.NativeFieldInfoPtr__ErrorContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr, "<ErrorContext>k__BackingField");
			ErrorEventArgs.NativeMethodInfoPtr_get_CurrentObject_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr, 100665276);
			ErrorEventArgs.NativeMethodInfoPtr_get_ErrorContext_Public_get_ErrorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr, 100665277);
			ErrorEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Object_ErrorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr, 100665278);
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x00041E50 File Offset: 0x00040050
		public unsafe Object CurrentObject
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorEventArgs.NativeMethodInfoPtr_get_CurrentObject_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00041E90 File Offset: 0x00040090
		public unsafe ErrorContext ErrorContext
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorEventArgs.NativeMethodInfoPtr_get_ErrorContext_Public_get_ErrorContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ErrorContext>(intPtr3) : null;
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00041ED0 File Offset: 0x000400D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748821, XrefRangeEnd = 748827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ErrorEventArgs(Object currentObject, ErrorContext errorContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Object_ErrorContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000051DF File Offset: 0x000033DF
		public ErrorEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00041F30 File Offset: 0x00040130
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x000051E8 File Offset: 0x000033E8
		public unsafe Object _CurrentObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorEventArgs.NativeFieldInfoPtr__CurrentObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorEventArgs.NativeFieldInfoPtr__CurrentObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00041F60 File Offset: 0x00040160
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00005207 File Offset: 0x00003407
		public unsafe ErrorContext _ErrorContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorEventArgs.NativeFieldInfoPtr__ErrorContext_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ErrorContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorEventArgs.NativeFieldInfoPtr__ErrorContext_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeFieldInfoPtr__CurrentObject_k__BackingField;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeFieldInfoPtr__ErrorContext_k__BackingField;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentObject_Public_get_Object_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorContext_Public_get_ErrorContext_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_ErrorContext_0;
	}
}
