using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000A0 RID: 160
	public class SteamInput : SteamClientClass<SteamInput>
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x00045288 File Offset: 0x00043488
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInput()
		{
			Il2CppClassPointerStore<SteamInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInput>.NativeClassPtr);
			SteamInput.NativeFieldInfoPtr_STEAM_CONTROLLER_MAX_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, "STEAM_CONTROLLER_MAX_COUNT");
			SteamInput.NativeFieldInfoPtr_queryArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, "queryArray");
			SteamInput.NativeFieldInfoPtr_DigitalHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, "DigitalHandles");
			SteamInput.NativeFieldInfoPtr_AnalogHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, "AnalogHandles");
			SteamInput.NativeFieldInfoPtr_ActionSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, "ActionSets");
			SteamInput.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100665503);
			SteamInput.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100665504);
			SteamInput.NativeMethodInfoPtr_RunFrame_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100665505);
			SteamInput.NativeMethodInfoPtr_get_Controllers_Public_Static_get_IEnumerable_1_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100665506);
			SteamInput.NativeMethodInfoPtr_GetDigitalActionGlyph_Public_Static_String_Controller_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100665507);
			SteamInput.NativeMethodInfoPtr_GetPngActionGlyph_Public_Static_String_Controller_String_GlyphSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100665508);
			SteamInput.NativeMethodInfoPtr_GetSvgActionGlyph_Public_Static_String_Controller_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100665509);
			SteamInput.NativeMethodInfoPtr_GetDigitalActionHandle_Internal_Static_InputDigitalActionHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100665510);
			SteamInput.NativeMethodInfoPtr_GetAnalogActionHandle_Internal_Static_InputAnalogActionHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100665511);
			SteamInput.NativeMethodInfoPtr_GetActionSetHandle_Internal_Static_InputActionSetHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100665512);
			SteamInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100665513);
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x000453F8 File Offset: 0x000435F8
		public unsafe static ISteamInput Internal
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 938785, RefRangeEnd = 938810, XrefRangeStart = 938782, XrefRangeEnd = 938785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamInput_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamInput>(intPtr3) : null;
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0004542C File Offset: 0x0004362C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938810, XrefRangeEnd = 938814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamInput.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00045478 File Offset: 0x00043678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938814, XrefRangeEnd = 938854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunFrame()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_RunFrame_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x000454A0 File Offset: 0x000436A0
		public unsafe static IEnumerable<Controller> Controllers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938854, XrefRangeEnd = 938859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_get_Controllers_Public_Static_get_IEnumerable_1_Controller_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Controller>>(intPtr3) : null;
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x000454D4 File Offset: 0x000436D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938859, XrefRangeEnd = 938869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDigitalActionGlyph(Controller controller, string action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controller;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetDigitalActionGlyph_Public_Static_String_Controller_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00045520 File Offset: 0x00043720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938869, XrefRangeEnd = 938879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPngActionGlyph(Controller controller, string action, GlyphSize size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controller;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetPngActionGlyph_Public_Static_String_Controller_String_GlyphSize_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00045578 File Offset: 0x00043778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938879, XrefRangeEnd = 938889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSvgActionGlyph(Controller controller, string action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controller;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetSvgActionGlyph_Public_Static_String_Controller_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000455C4 File Offset: 0x000437C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 938904, RefRangeEnd = 938908, XrefRangeStart = 938889, XrefRangeEnd = 938904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputDigitalActionHandle_t GetDigitalActionHandle(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetDigitalActionHandle_Internal_Static_InputDigitalActionHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00045608 File Offset: 0x00043808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 938923, RefRangeEnd = 938924, XrefRangeStart = 938908, XrefRangeEnd = 938923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputAnalogActionHandle_t GetAnalogActionHandle(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetAnalogActionHandle_Internal_Static_InputAnalogActionHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0004564C File Offset: 0x0004384C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938924, XrefRangeEnd = 938939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputActionSetHandle_t GetActionSetHandle(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetActionSetHandle_Internal_Static_InputActionSetHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00045690 File Offset: 0x00043890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938939, XrefRangeEnd = 938942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamInput()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000027AB File Offset: 0x000009AB
		public SteamInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x000456CC File Offset: 0x000438CC
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x000027B4 File Offset: 0x000009B4
		public unsafe static int STEAM_CONTROLLER_MAX_COUNT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInput.NativeFieldInfoPtr_STEAM_CONTROLLER_MAX_COUNT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInput.NativeFieldInfoPtr_STEAM_CONTROLLER_MAX_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x000456E8 File Offset: 0x000438E8
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x000027C2 File Offset: 0x000009C2
		public unsafe static Il2CppStructArray<InputHandle_t> queryArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamInput.NativeFieldInfoPtr_queryArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<InputHandle_t>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInput.NativeFieldInfoPtr_queryArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x00045710 File Offset: 0x00043910
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x000027D4 File Offset: 0x000009D4
		public unsafe static Dictionary<string, InputDigitalActionHandle_t> DigitalHandles
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamInput.NativeFieldInfoPtr_DigitalHandles, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, InputDigitalActionHandle_t>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInput.NativeFieldInfoPtr_DigitalHandles, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00045738 File Offset: 0x00043938
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x000027E6 File Offset: 0x000009E6
		public unsafe static Dictionary<string, InputAnalogActionHandle_t> AnalogHandles
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamInput.NativeFieldInfoPtr_AnalogHandles, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, InputAnalogActionHandle_t>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInput.NativeFieldInfoPtr_AnalogHandles, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00045760 File Offset: 0x00043960
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x000027F8 File Offset: 0x000009F8
		public unsafe static Dictionary<string, InputActionSetHandle_t> ActionSets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamInput.NativeFieldInfoPtr_ActionSets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, InputActionSetHandle_t>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInput.NativeFieldInfoPtr_ActionSets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeFieldInfoPtr_STEAM_CONTROLLER_MAX_COUNT;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeFieldInfoPtr_queryArray;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeFieldInfoPtr_DigitalHandles;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeFieldInfoPtr_AnalogHandles;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeFieldInfoPtr_ActionSets;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamInput_0;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeMethodInfoPtr_RunFrame_Public_Static_Void_0;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeMethodInfoPtr_get_Controllers_Public_Static_get_IEnumerable_1_Controller_0;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionGlyph_Public_Static_String_Controller_String_0;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeMethodInfoPtr_GetPngActionGlyph_Public_Static_String_Controller_String_GlyphSize_0;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeMethodInfoPtr_GetSvgActionGlyph_Public_Static_String_Controller_String_0;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionHandle_Internal_Static_InputDigitalActionHandle_t_String_0;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionHandle_Internal_Static_InputAnalogActionHandle_t_String_0;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr_GetActionSetHandle_Internal_Static_InputActionSetHandle_t_String_0;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000230 RID: 560
		[ObfuscatedName("Steamworks.SteamInput+<get_Controllers>d__7")]
		public sealed class _get_Controllers_d__7 : Object
		{
			// Token: 0x06001C44 RID: 7236 RVA: 0x00084390 File Offset: 0x00082590
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Controllers_d__7()
			{
				Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, "<get_Controllers>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr);
				SteamInput._get_Controllers_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr, "<>1__state");
				SteamInput._get_Controllers_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr, "<>2__current");
				SteamInput._get_Controllers_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr, "<>l__initialThreadId");
				SteamInput._get_Controllers_d__7.NativeFieldInfoPtr__num_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr, "<num>5__2");
				SteamInput._get_Controllers_d__7.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr, "<i>5__3");
				SteamInput._get_Controllers_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr, 100665515);
				SteamInput._get_Controllers_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr, 100665516);
				SteamInput._get_Controllers_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr, 100665517);
				SteamInput._get_Controllers_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Controller__get_Current_Private_Virtual_Final_New_get_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr, 100665518);
				SteamInput._get_Controllers_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr, 100665519);
				SteamInput._get_Controllers_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr, 100665520);
				SteamInput._get_Controllers_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Controller__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr, 100665521);
				SteamInput._get_Controllers_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr, 100665522);
			}

			// Token: 0x06001C45 RID: 7237 RVA: 0x000844C0 File Offset: 0x000826C0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Controllers_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInput._get_Controllers_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput._get_Controllers_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C46 RID: 7238 RVA: 0x00084508 File Offset: 0x00082708
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput._get_Controllers_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C47 RID: 7239 RVA: 0x0008453C File Offset: 0x0008273C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938762, XrefRangeEnd = 938772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput._get_Controllers_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000710 RID: 1808
			// (get) Token: 0x06001C48 RID: 7240 RVA: 0x00084578 File Offset: 0x00082778
			public unsafe Controller System.Collections.Generic.IEnumerator<Steamworks.Controller>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput._get_Controllers_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Controller__get_Current_Private_Virtual_Final_New_get_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C49 RID: 7241 RVA: 0x000845B4 File Offset: 0x000827B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938772, XrefRangeEnd = 938777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput._get_Controllers_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000711 RID: 1809
			// (get) Token: 0x06001C4A RID: 7242 RVA: 0x000845E8 File Offset: 0x000827E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938777, XrefRangeEnd = 938780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput._get_Controllers_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C4B RID: 7243 RVA: 0x00084628 File Offset: 0x00082828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938780, XrefRangeEnd = 938782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Controller> System_Collections_Generic_IEnumerable_Steamworks_Controller__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput._get_Controllers_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Controller__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Controller>>(intPtr3) : null;
			}

			// Token: 0x06001C4C RID: 7244 RVA: 0x00084668 File Offset: 0x00082868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput._get_Controllers_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001C4D RID: 7245 RVA: 0x00009A7F File Offset: 0x00007C7F
			public _get_Controllers_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700070B RID: 1803
			// (get) Token: 0x06001C4E RID: 7246 RVA: 0x000846A8 File Offset: 0x000828A8
			// (set) Token: 0x06001C4F RID: 7247 RVA: 0x00009A88 File Offset: 0x00007C88
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInput._get_Controllers_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInput._get_Controllers_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x06001C50 RID: 7248 RVA: 0x000846D0 File Offset: 0x000828D0
			// (set) Token: 0x06001C51 RID: 7249 RVA: 0x00009AA3 File Offset: 0x00007CA3
			public unsafe Controller __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInput._get_Controllers_d__7.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInput._get_Controllers_d__7.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x06001C52 RID: 7250 RVA: 0x000846F8 File Offset: 0x000828F8
			// (set) Token: 0x06001C53 RID: 7251 RVA: 0x00009ABE File Offset: 0x00007CBE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInput._get_Controllers_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInput._get_Controllers_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00084720 File Offset: 0x00082920
			// (set) Token: 0x06001C55 RID: 7253 RVA: 0x00009AD9 File Offset: 0x00007CD9
			public unsafe int _num_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInput._get_Controllers_d__7.NativeFieldInfoPtr__num_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInput._get_Controllers_d__7.NativeFieldInfoPtr__num_5__2)) = value;
				}
			}

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x06001C56 RID: 7254 RVA: 0x00084748 File Offset: 0x00082948
			// (set) Token: 0x06001C57 RID: 7255 RVA: 0x00009AF4 File Offset: 0x00007CF4
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInput._get_Controllers_d__7.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInput._get_Controllers_d__7.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400208C RID: 8332
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400208D RID: 8333
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400208E RID: 8334
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400208F RID: 8335
			private static readonly IntPtr NativeFieldInfoPtr__num_5__2;

			// Token: 0x04002090 RID: 8336
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04002091 RID: 8337
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002092 RID: 8338
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002093 RID: 8339
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002094 RID: 8340
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Controller__get_Current_Private_Virtual_Final_New_get_Controller_0;

			// Token: 0x04002095 RID: 8341
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002096 RID: 8342
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002097 RID: 8343
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Controller__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Controller_0;

			// Token: 0x04002098 RID: 8344
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
