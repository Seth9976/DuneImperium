using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000034 RID: 52
	public class SecureStringHasher : Object
	{
		// Token: 0x06000310 RID: 784 RVA: 0x000220B4 File Offset: 0x000202B4
		// Note: this type is marked as 'beforefieldinit'.
		static SecureStringHasher()
		{
			Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "SecureStringHasher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr);
			SecureStringHasher.NativeFieldInfoPtr_hashCodeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, "hashCodeDelegate");
			SecureStringHasher.NativeFieldInfoPtr_hashCodeRandomizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, "hashCodeRandomizer");
			SecureStringHasher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663714);
			SecureStringHasher.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663715);
			SecureStringHasher.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663716);
			SecureStringHasher.NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663717);
			SecureStringHasher.NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, 100663718);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00022170 File Offset: 0x00020370
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 364765, RefRangeEnd = 364768, XrefRangeStart = 364763, XrefRangeEnd = 364765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecureStringHasher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000221AC File Offset: 0x000203AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364768, XrefRangeEnd = 364769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(string x, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0002220C File Offset: 0x0002040C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 364776, RefRangeEnd = 364782, XrefRangeStart = 364769, XrefRangeEnd = 364776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0002225C File Offset: 0x0002045C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364782, XrefRangeEnd = 364784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCodeOfString(string key, int sLen, long additionalEntropy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalEntropy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000222BC File Offset: 0x000204BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 364804, RefRangeEnd = 364805, XrefRangeStart = 364784, XrefRangeEnd = 364804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecureStringHasher.HashCodeOfStringDelegate>(intPtr3) : null;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000322F File Offset: 0x0000142F
		public SecureStringHasher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000317 RID: 791 RVA: 0x000222F0 File Offset: 0x000204F0
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00003238 File Offset: 0x00001438
		public unsafe static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecureStringHasher.NativeFieldInfoPtr_hashCodeDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecureStringHasher.HashCodeOfStringDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecureStringHasher.NativeFieldInfoPtr_hashCodeDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00022318 File Offset: 0x00020518
		// (set) Token: 0x0600031A RID: 794 RVA: 0x0000324A File Offset: 0x0000144A
		public unsafe int hashCodeRandomizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureStringHasher.NativeFieldInfoPtr_hashCodeRandomizer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureStringHasher.NativeFieldInfoPtr_hashCodeRandomizer)) = value;
			}
		}

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_hashCodeDelegate;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_hashCodeRandomizer;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_String_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_String_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeOfString_Private_Static_Int32_String_Int32_Int64_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeDelegate_Private_Static_HashCodeOfStringDelegate_0;

		// Token: 0x02000218 RID: 536
		public sealed class HashCodeOfStringDelegate : MulticastDelegate
		{
			// Token: 0x06002EED RID: 12013 RVA: 0x0001372A File Offset: 0x0001192A
			// Note: this type is marked as 'beforefieldinit'.
			static HashCodeOfStringDelegate()
			{
				Il2CppClassPointerStore<SecureStringHasher.HashCodeOfStringDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SecureStringHasher>.NativeClassPtr, "HashCodeOfStringDelegate");
				SecureStringHasher.HashCodeOfStringDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher.HashCodeOfStringDelegate>.NativeClassPtr, 100663719);
				SecureStringHasher.HashCodeOfStringDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHasher.HashCodeOfStringDelegate>.NativeClassPtr, 100663720);
			}

			// Token: 0x06002EEE RID: 12014 RVA: 0x000D5974 File Offset: 0x000D3B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364759, XrefRangeEnd = 364763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HashCodeOfStringDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecureStringHasher.HashCodeOfStringDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.HashCodeOfStringDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EEF RID: 12015 RVA: 0x000D59D0 File Offset: 0x000D3BD0
			[CallerCount(0)]
			public unsafe int Invoke(string s, int sLen, long additionalEntropy)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sLen;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalEntropy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureStringHasher.HashCodeOfStringDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002EF0 RID: 12016 RVA: 0x00013768 File Offset: 0x00011968
			public HashCodeOfStringDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002EF1 RID: 12017 RVA: 0x00013771 File Offset: 0x00011971
			public static implicit operator SecureStringHasher.HashCodeOfStringDelegate(Func<string, int, long, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<SecureStringHasher.HashCodeOfStringDelegate>(A_0);
			}

			// Token: 0x06002EF2 RID: 12018 RVA: 0x00013779 File Offset: 0x00011979
			public static SecureStringHasher.HashCodeOfStringDelegate operator +(SecureStringHasher.HashCodeOfStringDelegate A_0, SecureStringHasher.HashCodeOfStringDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SecureStringHasher.HashCodeOfStringDelegate>();
			}

			// Token: 0x06002EF3 RID: 12019 RVA: 0x00013787 File Offset: 0x00011987
			public static SecureStringHasher.HashCodeOfStringDelegate operator -(SecureStringHasher.HashCodeOfStringDelegate A_0, SecureStringHasher.HashCodeOfStringDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<SecureStringHasher.HashCodeOfStringDelegate>();
				}
				return delegate2;
			}

			// Token: 0x0400239B RID: 9115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400239C RID: 9116
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_String_Int32_Int64_0;
		}
	}
}
