using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000B0 RID: 176
	public class ValidationEventArgs : EventArgs
	{
		// Token: 0x06000FC6 RID: 4038 RVA: 0x00058E90 File Offset: 0x00057090
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationEventArgs()
		{
			Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Schema", "ValidationEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr);
			ValidationEventArgs.NativeFieldInfoPtr__ex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, "_ex");
			ValidationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_JsonSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, 100666073);
			ValidationEventArgs.NativeMethodInfoPtr_get_Exception_Public_get_JsonSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, 100666074);
			ValidationEventArgs.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, 100666075);
			ValidationEventArgs.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, 100666076);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00058F24 File Offset: 0x00057124
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 755975, RefRangeEnd = 755977, XrefRangeStart = 755964, XrefRangeEnd = 755975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationEventArgs(JsonSchemaException ex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_JsonSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x00058F70 File Offset: 0x00057170
		public unsafe JsonSchemaException Exception
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventArgs.NativeMethodInfoPtr_get_Exception_Public_get_JsonSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchemaException>(intPtr3) : null;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x00058FB0 File Offset: 0x000571B0
		public unsafe string Path
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventArgs.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00058FE8 File Offset: 0x000571E8
		public unsafe string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventArgs.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0000756F File Offset: 0x0000576F
		public ValidationEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00059020 File Offset: 0x00057220
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x00007578 File Offset: 0x00005778
		public unsafe JsonSchemaException _ex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationEventArgs.NativeFieldInfoPtr__ex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchemaException>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationEventArgs.NativeFieldInfoPtr__ex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeFieldInfoPtr__ex;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_JsonSchemaException_0;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_get_JsonSchemaException_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;
	}
}
