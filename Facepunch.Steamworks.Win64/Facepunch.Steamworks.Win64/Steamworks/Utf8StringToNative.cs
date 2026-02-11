using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Steamworks
{
	// Token: 0x020000CD RID: 205
	public class Utf8StringToNative : Object
	{
		// Token: 0x06000CF0 RID: 3312 RVA: 0x00054584 File Offset: 0x00052784
		// Note: this type is marked as 'beforefieldinit'.
		static Utf8StringToNative()
		{
			Il2CppClassPointerStore<Utf8StringToNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "Utf8StringToNative");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utf8StringToNative>.NativeClassPtr);
			Utf8StringToNative.NativeMethodInfoPtr_MarshalManagedToNative_Public_Virtual_Final_New_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utf8StringToNative>.NativeClassPtr, 100666448);
			Utf8StringToNative.NativeMethodInfoPtr_MarshalNativeToManaged_Public_Virtual_Final_New_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utf8StringToNative>.NativeClassPtr, 100666449);
			Utf8StringToNative.NativeMethodInfoPtr_CleanUpNativeData_Public_Virtual_Final_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utf8StringToNative>.NativeClassPtr, 100666450);
			Utf8StringToNative.NativeMethodInfoPtr_CleanUpManagedData_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utf8StringToNative>.NativeClassPtr, 100666451);
			Utf8StringToNative.NativeMethodInfoPtr_GetNativeDataSize_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utf8StringToNative>.NativeClassPtr, 100666452);
			Utf8StringToNative.NativeMethodInfoPtr_GetInstance_Public_Static_ICustomMarshaler_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utf8StringToNative>.NativeClassPtr, 100666453);
			Utf8StringToNative.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utf8StringToNative>.NativeClassPtr, 100666454);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00054640 File Offset: 0x00052840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948227, XrefRangeEnd = 948230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IntPtr MarshalManagedToNative(Object managedObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(managedObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utf8StringToNative.NativeMethodInfoPtr_MarshalManagedToNative_Public_Virtual_Final_New_IntPtr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00054690 File Offset: 0x00052890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948230, XrefRangeEnd = 948235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object MarshalNativeToManaged(IntPtr pNativeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pNativeData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utf8StringToNative.NativeMethodInfoPtr_MarshalNativeToManaged_Public_Virtual_Final_New_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x000546DC File Offset: 0x000528DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948235, XrefRangeEnd = 948239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CleanUpNativeData(IntPtr pNativeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pNativeData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utf8StringToNative.NativeMethodInfoPtr_CleanUpNativeData_Public_Virtual_Final_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0005471C File Offset: 0x0005291C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948239, XrefRangeEnd = 948244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CleanUpManagedData(Object managedObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(managedObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utf8StringToNative.NativeMethodInfoPtr_CleanUpManagedData_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00054760 File Offset: 0x00052960
		[CallerCount(0)]
		public unsafe virtual int GetNativeDataSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utf8StringToNative.NativeMethodInfoPtr_GetNativeDataSize_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0005479C File Offset: 0x0005299C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948244, XrefRangeEnd = 948248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICustomMarshaler GetInstance(string cookie)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cookie);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utf8StringToNative.NativeMethodInfoPtr_GetInstance_Public_Static_ICustomMarshaler_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomMarshaler>(intPtr3) : null;
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x000547E0 File Offset: 0x000529E0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Utf8StringToNative()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Utf8StringToNative>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utf8StringToNative.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0000340C File Offset: 0x0000160C
		public Utf8StringToNative(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_MarshalManagedToNative_Public_Virtual_Final_New_IntPtr_Object_0;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr_MarshalNativeToManaged_Public_Virtual_Final_New_Object_IntPtr_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr_CleanUpNativeData_Public_Virtual_Final_New_Void_IntPtr_0;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_CleanUpManagedData_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeDataSize_Public_Virtual_Final_New_Int32_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Public_Static_ICustomMarshaler_String_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
