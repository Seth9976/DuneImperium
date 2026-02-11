using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000DC RID: 220
	public sealed class X509ExtensionEnumerator : Object
	{
		// Token: 0x06000EB6 RID: 3766 RVA: 0x00053A60 File Offset: 0x00051C60
		// Note: this type is marked as 'beforefieldinit'.
		static X509ExtensionEnumerator()
		{
			Il2CppClassPointerStore<X509ExtensionEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ExtensionEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ExtensionEnumerator>.NativeClassPtr);
			X509ExtensionEnumerator.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ExtensionEnumerator>.NativeClassPtr, "enumerator");
			X509ExtensionEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionEnumerator>.NativeClassPtr, 100665437);
			X509ExtensionEnumerator.NativeMethodInfoPtr_get_Current_Public_get_X509Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionEnumerator>.NativeClassPtr, 100665438);
			X509ExtensionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionEnumerator>.NativeClassPtr, 100665439);
			X509ExtensionEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionEnumerator>.NativeClassPtr, 100665440);
			X509ExtensionEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ExtensionEnumerator>.NativeClassPtr, 100665441);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00053B08 File Offset: 0x00051D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455602, XrefRangeEnd = 455605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ExtensionEnumerator(ArrayList list)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ExtensionEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ExtensionEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00053B54 File Offset: 0x00051D54
		public unsafe X509Extension Current
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 455610, RefRangeEnd = 455612, XrefRangeStart = 455605, XrefRangeEnd = 455610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ExtensionEnumerator.NativeMethodInfoPtr_get_Current_Public_get_X509Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Extension>(intPtr3) : null;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00053B94 File Offset: 0x00051D94
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455612, XrefRangeEnd = 455616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ExtensionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00053BD4 File Offset: 0x00051DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 455620, RefRangeEnd = 455621, XrefRangeStart = 455616, XrefRangeEnd = 455620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ExtensionEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00053C10 File Offset: 0x00051E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455621, XrefRangeEnd = 455625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ExtensionEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00007531 File Offset: 0x00005731
		public X509ExtensionEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x00053C44 File Offset: 0x00051E44
		// (set) Token: 0x06000EBE RID: 3774 RVA: 0x0000753A File Offset: 0x0000573A
		public unsafe IEnumerator enumerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ExtensionEnumerator.NativeFieldInfoPtr_enumerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ExtensionEnumerator.NativeFieldInfoPtr_enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeFieldInfoPtr_enumerator;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_X509Extension_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
