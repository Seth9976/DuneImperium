using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000D4 RID: 212
	public sealed class X509ChainElementEnumerator : Object
	{
		// Token: 0x06000E06 RID: 3590 RVA: 0x00050FAC File Offset: 0x0004F1AC
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainElementEnumerator()
		{
			Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainElementEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr);
			X509ChainElementEnumerator.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr, "enumerator");
			X509ChainElementEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr, 100665342);
			X509ChainElementEnumerator.NativeMethodInfoPtr_get_Current_Public_get_X509ChainElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr, 100665343);
			X509ChainElementEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr, 100665344);
			X509ChainElementEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr, 100665345);
			X509ChainElementEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr, 100665346);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00051054 File Offset: 0x0004F254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454636, XrefRangeEnd = 454642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainElementEnumerator(IEnumerable enumerable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainElementEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x000510A0 File Offset: 0x0004F2A0
		public unsafe X509ChainElement Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454642, XrefRangeEnd = 454647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementEnumerator.NativeMethodInfoPtr_get_Current_Public_get_X509ChainElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x000510E0 File Offset: 0x0004F2E0
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454647, XrefRangeEnd = 454651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00051120 File Offset: 0x0004F320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454651, XrefRangeEnd = 454655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0005115C File Offset: 0x0004F35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454655, XrefRangeEnd = 454659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainElementEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0000711A File Offset: 0x0000531A
		public X509ChainElementEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00051190 File Offset: 0x0004F390
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00007123 File Offset: 0x00005323
		public unsafe IEnumerator enumerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElementEnumerator.NativeFieldInfoPtr_enumerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainElementEnumerator.NativeFieldInfoPtr_enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeFieldInfoPtr_enumerator;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_X509ChainElement_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
