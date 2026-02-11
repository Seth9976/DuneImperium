using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000253 RID: 595
	public sealed class GlobalKeyword : ValueType
	{
		// Token: 0x060028AD RID: 10413 RVA: 0x000A9E90 File Offset: 0x000A8090
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalKeyword()
		{
			Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GlobalKeyword");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr);
			GlobalKeyword.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, "m_Name");
			GlobalKeyword.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, "m_Index");
			GlobalKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, 100668480);
			GlobalKeyword.GetGlobalKeywordCountDelegateField = IL2CPP.ResolveICall<GlobalKeyword.GetGlobalKeywordCountDelegate>("UnityEngine.Rendering.GlobalKeyword::GetGlobalKeywordCount");
			GlobalKeyword.GetGlobalKeywordIndexDelegateField = IL2CPP.ResolveICall<GlobalKeyword.GetGlobalKeywordIndexDelegate>("UnityEngine.Rendering.GlobalKeyword::GetGlobalKeywordIndex");
			GlobalKeyword.CreateGlobalKeywordDelegateField = IL2CPP.ResolveICall<GlobalKeyword.CreateGlobalKeywordDelegate>("UnityEngine.Rendering.GlobalKeyword::CreateGlobalKeyword");
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000A9F2C File Offset: 0x000A812C
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalKeyword.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x0000FBF4 File Offset: 0x0000DDF4
		public GlobalKeyword(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x0000FBFD File Offset: 0x0000DDFD
		public GlobalKeyword()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr))
		{
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x000A9F68 File Offset: 0x000A8168
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x0000FC0F File Offset: 0x0000DE0F
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalKeyword.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalKeyword.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000A9F90 File Offset: 0x000A8190
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x0000FC2E File Offset: 0x0000DE2E
		public unsafe uint m_Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalKeyword.NativeFieldInfoPtr_m_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalKeyword.NativeFieldInfoPtr_m_Index)) = value;
			}
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x0000FC49 File Offset: 0x0000DE49
		public static uint GetGlobalKeywordCount()
		{
			return GlobalKeyword.GetGlobalKeywordCountDelegateField();
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x0000FC55 File Offset: 0x0000DE55
		public static uint GetGlobalKeywordIndex(string keyword)
		{
			return GlobalKeyword.GetGlobalKeywordIndexDelegateField(IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x0000FC67 File Offset: 0x0000DE67
		public static void CreateGlobalKeyword(string keyword)
		{
			GlobalKeyword.CreateGlobalKeywordDelegateField(IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060028B8 RID: 10424 RVA: 0x000A9FB8 File Offset: 0x000A81B8
		public string name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x000A9FD0 File Offset: 0x000A81D0
		public static GlobalKeyword Create(string name)
		{
			GlobalKeyword.CreateGlobalKeyword(name);
			return new GlobalKeyword(name);
		}

		// Token: 0x04002437 RID: 9271
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04002438 RID: 9272
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x04002439 RID: 9273
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400243A RID: 9274
		private static readonly GlobalKeyword.GetGlobalKeywordCountDelegate GetGlobalKeywordCountDelegateField;

		// Token: 0x0400243B RID: 9275
		private static readonly GlobalKeyword.GetGlobalKeywordIndexDelegate GetGlobalKeywordIndexDelegateField;

		// Token: 0x0400243C RID: 9276
		private static readonly GlobalKeyword.CreateGlobalKeywordDelegate CreateGlobalKeywordDelegateField;

		// Token: 0x020009EA RID: 2538
		// (Invoke) Token: 0x06003CF1 RID: 15601
		private delegate uint GetGlobalKeywordCountDelegate();

		// Token: 0x020009EB RID: 2539
		// (Invoke) Token: 0x06003CF3 RID: 15603
		private delegate uint GetGlobalKeywordIndexDelegate(IntPtr keyword);

		// Token: 0x020009EC RID: 2540
		// (Invoke) Token: 0x06003CF5 RID: 15605
		private delegate void CreateGlobalKeywordDelegate(IntPtr keyword);
	}
}
