using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000CB RID: 203
	public sealed class X509Certificate2Enumerator : Object
	{
		// Token: 0x06000D6D RID: 3437 RVA: 0x0004E4E4 File Offset: 0x0004C6E4
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate2Enumerator()
		{
			Il2CppClassPointerStore<X509Certificate2Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Certificate2Enumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate2Enumerator>.NativeClassPtr);
			X509Certificate2Enumerator.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2Enumerator>.NativeClassPtr, "enumerator");
			X509Certificate2Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2Collection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Enumerator>.NativeClassPtr, 100665227);
			X509Certificate2Enumerator.NativeMethodInfoPtr_get_Current_Public_get_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Enumerator>.NativeClassPtr, 100665228);
			X509Certificate2Enumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Enumerator>.NativeClassPtr, 100665229);
			X509Certificate2Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Enumerator>.NativeClassPtr, 100665230);
			X509Certificate2Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Enumerator>.NativeClassPtr, 100665231);
			X509Certificate2Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Enumerator>.NativeClassPtr, 100665232);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0004E5A0 File Offset: 0x0004C7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453881, XrefRangeEnd = 453887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2Enumerator(X509Certificate2Collection collection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2Enumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2Collection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x0004E5EC File Offset: 0x0004C7EC
		public unsafe X509Certificate2 Current
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 453892, RefRangeEnd = 453896, XrefRangeStart = 453887, XrefRangeEnd = 453892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Enumerator.NativeMethodInfoPtr_get_Current_Public_get_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2>(intPtr3) : null;
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0004E62C File Offset: 0x0004C82C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 453900, RefRangeEnd = 453904, XrefRangeStart = 453896, XrefRangeEnd = 453900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Enumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x0004E668 File Offset: 0x0004C868
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453904, XrefRangeEnd = 453908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0004E6A8 File Offset: 0x0004C8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453908, XrefRangeEnd = 453912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_Collections_IEnumerator_MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0004E6E4 File Offset: 0x0004C8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453912, XrefRangeEnd = 453916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00006F2A File Offset: 0x0000512A
		public X509Certificate2Enumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x0004E718 File Offset: 0x0004C918
		// (set) Token: 0x06000D76 RID: 3446 RVA: 0x00006F33 File Offset: 0x00005133
		public unsafe IEnumerator enumerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2Enumerator.NativeFieldInfoPtr_enumerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2Enumerator.NativeFieldInfoPtr_enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeFieldInfoPtr_enumerator;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate2Collection_0;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_X509Certificate2_0;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
	}
}
