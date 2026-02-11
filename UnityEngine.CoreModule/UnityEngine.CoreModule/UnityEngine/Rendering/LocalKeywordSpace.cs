using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000255 RID: 597
	[StructLayout(2)]
	public struct LocalKeywordSpace
	{
		// Token: 0x060028DB RID: 10459 RVA: 0x000AA504 File Offset: 0x000A8704
		// Note: this type is marked as 'beforefieldinit'.
		static LocalKeywordSpace()
		{
			Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "LocalKeywordSpace");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr);
			LocalKeywordSpace.NativeFieldInfoPtr_m_KeywordSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, "m_KeywordSpace");
			LocalKeywordSpace.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100668488);
			LocalKeywordSpace.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100668489);
			LocalKeywordSpace.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalKeywordSpace_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100668490);
			LocalKeywordSpace.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, 100668491);
			LocalKeywordSpace.GetKeywords_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeywordSpace.GetKeywords_InjectedDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeywords_Injected");
			LocalKeywordSpace.GetKeywordNames_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeywordSpace.GetKeywordNames_InjectedDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeywordNames_Injected");
			LocalKeywordSpace.GetKeywordCount_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeywordSpace.GetKeywordCount_InjectedDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeywordCount_Injected");
			LocalKeywordSpace.GetKeyword_InjectedDelegateField = IL2CPP.ResolveICall<LocalKeywordSpace.GetKeyword_InjectedDelegate>("UnityEngine.Rendering.LocalKeywordSpace::GetKeyword_Injected");
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x000AA5D4 File Offset: 0x000A87D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685531, XrefRangeEnd = 685535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeywordSpace.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x000AA618 File Offset: 0x000A8818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685535, XrefRangeEnd = 685536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(LocalKeywordSpace rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeywordSpace.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeywordSpace_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x000AA658 File Offset: 0x000A8858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685536, XrefRangeEnd = 685537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(LocalKeywordSpace lhs, LocalKeywordSpace rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeywordSpace.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalKeywordSpace_LocalKeywordSpace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x000AA6A4 File Offset: 0x000A88A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalKeywordSpace.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x0000FD55 File Offset: 0x0000DF55
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalKeywordSpace>.NativeClassPtr, ref this));
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x0000FD67 File Offset: 0x0000DF67
		public Il2CppReferenceArray<LocalKeyword> GetKeywords()
		{
			return LocalKeywordSpace.GetKeywords_Injected(ref this);
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x0000FD6F File Offset: 0x0000DF6F
		public Il2CppStringArray GetKeywordNames()
		{
			return LocalKeywordSpace.GetKeywordNames_Injected(ref this);
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x0000FD77 File Offset: 0x0000DF77
		public uint GetKeywordCount()
		{
			return LocalKeywordSpace.GetKeywordCount_Injected(ref this);
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x000AA6D4 File Offset: 0x000A88D4
		public LocalKeyword GetKeyword(string name)
		{
			LocalKeyword localKeyword;
			LocalKeywordSpace.GetKeyword_Injected(ref this, name, out localKeyword);
			return localKeyword;
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x000AA6EC File Offset: 0x000A88EC
		public Il2CppReferenceArray<LocalKeyword> keywords
		{
			get
			{
				return this.GetKeywords();
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060028E6 RID: 10470 RVA: 0x000AA704 File Offset: 0x000A8904
		public Il2CppStringArray keywordNames
		{
			get
			{
				return this.GetKeywordNames();
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x000AA71C File Offset: 0x000A891C
		public uint keywordCount
		{
			get
			{
				return this.GetKeywordCount();
			}
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x000AA734 File Offset: 0x000A8934
		public LocalKeyword FindKeyword(string name)
		{
			return this.GetKeyword(name);
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x000AA750 File Offset: 0x000A8950
		public static bool operator !=(LocalKeywordSpace lhs, LocalKeywordSpace rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000AA76C File Offset: 0x000A896C
		public static Il2CppReferenceArray<LocalKeyword> GetKeywords_Injected(ref LocalKeywordSpace _unity_self)
		{
			IntPtr intPtr = LocalKeywordSpace.GetKeywords_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalKeyword>>(intPtr2) : null;
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x000AA794 File Offset: 0x000A8994
		public static Il2CppStringArray GetKeywordNames_Injected(ref LocalKeywordSpace _unity_self)
		{
			IntPtr intPtr = LocalKeywordSpace.GetKeywordNames_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x0000FD7F File Offset: 0x0000DF7F
		public static uint GetKeywordCount_Injected(ref LocalKeywordSpace _unity_self)
		{
			return LocalKeywordSpace.GetKeywordCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x000AA7BC File Offset: 0x000A89BC
		public unsafe static void GetKeyword_Injected(ref LocalKeywordSpace _unity_self, string name, out LocalKeyword ret)
		{
			LocalKeywordSpace.GetKeyword_InjectedDelegate getKeyword_InjectedDelegateField = LocalKeywordSpace.GetKeyword_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			getKeyword_InjectedDelegateField(ref _unity_self, intPtr, &intPtr2);
		}

		// Token: 0x0400244D RID: 9293
		private static readonly IntPtr NativeFieldInfoPtr_m_KeywordSpace;

		// Token: 0x0400244E RID: 9294
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400244F RID: 9295
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalKeywordSpace_0;

		// Token: 0x04002450 RID: 9296
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalKeywordSpace_LocalKeywordSpace_0;

		// Token: 0x04002451 RID: 9297
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002452 RID: 9298
		[FieldOffset(0)]
		public readonly IntPtr m_KeywordSpace;

		// Token: 0x04002453 RID: 9299
		private static readonly LocalKeywordSpace.GetKeywords_InjectedDelegate GetKeywords_InjectedDelegateField;

		// Token: 0x04002454 RID: 9300
		private static readonly LocalKeywordSpace.GetKeywordNames_InjectedDelegate GetKeywordNames_InjectedDelegateField;

		// Token: 0x04002455 RID: 9301
		private static readonly LocalKeywordSpace.GetKeywordCount_InjectedDelegate GetKeywordCount_InjectedDelegateField;

		// Token: 0x04002456 RID: 9302
		private static readonly LocalKeywordSpace.GetKeyword_InjectedDelegate GetKeyword_InjectedDelegateField;

		// Token: 0x020009F3 RID: 2547
		// (Invoke) Token: 0x06003D03 RID: 15619
		private delegate IntPtr GetKeywords_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009F4 RID: 2548
		// (Invoke) Token: 0x06003D05 RID: 15621
		private delegate IntPtr GetKeywordNames_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009F5 RID: 2549
		// (Invoke) Token: 0x06003D07 RID: 15623
		private delegate uint GetKeywordCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009F6 RID: 2550
		// (Invoke) Token: 0x06003D09 RID: 15625
		private delegate void GetKeyword_InjectedDelegate(IntPtr _unity_self, IntPtr name, [Out] IntPtr ret);
	}
}
