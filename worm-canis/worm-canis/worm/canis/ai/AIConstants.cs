using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;

namespace worm.canis.ai
{
	// Token: 0x02000212 RID: 530
	public static class AIConstants : Object
	{
		// Token: 0x060015B1 RID: 5553 RVA: 0x000A9BC0 File Offset: 0x000A7DC0
		// Note: this type is marked as 'beforefieldinit'.
		static AIConstants()
		{
			Il2CppClassPointerStore<AIConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.ai", "AIConstants");
			AIConstants.NativeFieldInfoPtr_EasyAIConstantsRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIConstants>.NativeClassPtr, "EasyAIConstantsRef");
			AIConstants.NativeFieldInfoPtr_MediumAIConstantsRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIConstants>.NativeClassPtr, "MediumAIConstantsRef");
			AIConstants.NativeFieldInfoPtr_HardAIConstantsRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIConstants>.NativeClassPtr, "HardAIConstantsRef");
			AIConstants.NativeFieldInfoPtr_loadedConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIConstants>.NativeClassPtr, "loadedConstants");
			AIConstants.NativeMethodInfoPtr_SetInstance_Public_Static_Void_Int32_AIConstantsRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIConstants>.NativeClassPtr, 100666693);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000A9C4C File Offset: 0x000A7E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122452, XrefRangeEnd = 122524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInstance(int aiLevel, AIConstantsRef ai)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aiLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ai);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIConstants.NativeMethodInfoPtr_SetInstance_Public_Static_Void_Int32_AIConstantsRef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0000A46C File Offset: 0x0000866C
		public AIConstants(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x000A9C90 File Offset: 0x000A7E90
		// (set) Token: 0x060015B5 RID: 5557 RVA: 0x0000A475 File Offset: 0x00008675
		public unsafe static AIConstantsRef EasyAIConstantsRef
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AIConstants.NativeFieldInfoPtr_EasyAIConstantsRef, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AIConstantsRef>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AIConstants.NativeFieldInfoPtr_EasyAIConstantsRef, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x000A9CB8 File Offset: 0x000A7EB8
		// (set) Token: 0x060015B7 RID: 5559 RVA: 0x0000A487 File Offset: 0x00008687
		public unsafe static AIConstantsRef MediumAIConstantsRef
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AIConstants.NativeFieldInfoPtr_MediumAIConstantsRef, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AIConstantsRef>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AIConstants.NativeFieldInfoPtr_MediumAIConstantsRef, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x000A9CE0 File Offset: 0x000A7EE0
		// (set) Token: 0x060015B9 RID: 5561 RVA: 0x0000A499 File Offset: 0x00008699
		public unsafe static AIConstantsRef HardAIConstantsRef
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AIConstants.NativeFieldInfoPtr_HardAIConstantsRef, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AIConstantsRef>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AIConstants.NativeFieldInfoPtr_HardAIConstantsRef, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x000A9D08 File Offset: 0x000A7F08
		// (set) Token: 0x060015BB RID: 5563 RVA: 0x0000A4AB File Offset: 0x000086AB
		public unsafe static ConcurrentDictionary<int, AIConstantsRef> loadedConstants
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AIConstants.NativeFieldInfoPtr_loadedConstants, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<int, AIConstantsRef>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AIConstants.NativeFieldInfoPtr_loadedConstants, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeFieldInfoPtr_EasyAIConstantsRef;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeFieldInfoPtr_MediumAIConstantsRef;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeFieldInfoPtr_HardAIConstantsRef;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeFieldInfoPtr_loadedConstants;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr_SetInstance_Public_Static_Void_Int32_AIConstantsRef_0;
	}
}
