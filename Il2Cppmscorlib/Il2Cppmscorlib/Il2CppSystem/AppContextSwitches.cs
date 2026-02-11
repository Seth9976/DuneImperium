using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000125 RID: 293
	public static class AppContextSwitches : Object
	{
		// Token: 0x0600138C RID: 5004 RVA: 0x000849E0 File Offset: 0x00082BE0
		// Note: this type is marked as 'beforefieldinit'.
		static AppContextSwitches()
		{
			Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppContextSwitches");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr);
			AppContextSwitches.NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "SetActorAsReferenceWhenCopyingClaimsIdentity");
			AppContextSwitches.NativeFieldInfoPtr_EnforceJapaneseEraYearRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "EnforceJapaneseEraYearRanges");
			AppContextSwitches.NativeFieldInfoPtr_FormatJapaneseFirstYearAsANumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "FormatJapaneseFirstYearAsANumber");
			AppContextSwitches.NativeFieldInfoPtr_EnforceLegacyJapaneseDateParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "EnforceLegacyJapaneseDateParsing");
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x000063BE File Offset: 0x000045BE
		public AppContextSwitches(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x00084A60 File Offset: 0x00082C60
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x000063C7 File Offset: 0x000045C7
		public unsafe static bool SetActorAsReferenceWhenCopyingClaimsIdentity
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AppContextSwitches.NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContextSwitches.NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity, (void*)(&value));
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x00084A7C File Offset: 0x00082C7C
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x000063D5 File Offset: 0x000045D5
		public unsafe static bool EnforceJapaneseEraYearRanges
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AppContextSwitches.NativeFieldInfoPtr_EnforceJapaneseEraYearRanges, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContextSwitches.NativeFieldInfoPtr_EnforceJapaneseEraYearRanges, (void*)(&value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x00084A98 File Offset: 0x00082C98
		// (set) Token: 0x06001393 RID: 5011 RVA: 0x000063E3 File Offset: 0x000045E3
		public unsafe static bool FormatJapaneseFirstYearAsANumber
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AppContextSwitches.NativeFieldInfoPtr_FormatJapaneseFirstYearAsANumber, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContextSwitches.NativeFieldInfoPtr_FormatJapaneseFirstYearAsANumber, (void*)(&value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x00084AB4 File Offset: 0x00082CB4
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x000063F1 File Offset: 0x000045F1
		public unsafe static bool EnforceLegacyJapaneseDateParsing
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AppContextSwitches.NativeFieldInfoPtr_EnforceLegacyJapaneseDateParsing, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppContextSwitches.NativeFieldInfoPtr_EnforceLegacyJapaneseDateParsing, (void*)(&value));
			}
		}

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeFieldInfoPtr_EnforceJapaneseEraYearRanges;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeFieldInfoPtr_FormatJapaneseFirstYearAsANumber;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeFieldInfoPtr_EnforceLegacyJapaneseDateParsing;
	}
}
