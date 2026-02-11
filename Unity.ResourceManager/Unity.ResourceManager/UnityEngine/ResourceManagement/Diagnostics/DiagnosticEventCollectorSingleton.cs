using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.Diagnostics
{
	// Token: 0x0200004B RID: 75
	public class DiagnosticEventCollectorSingleton : ComponentSingleton<DiagnosticEventCollectorSingleton>
	{
		// Token: 0x060003C8 RID: 968 RVA: 0x00013850 File Offset: 0x00011A50
		// Note: this type is marked as 'beforefieldinit'.
		static DiagnosticEventCollectorSingleton()
		{
			Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Diagnostics", "DiagnosticEventCollectorSingleton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr);
			DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_s_editorConnectionGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, "s_editorConnectionGuid");
			DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_m_CreatedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, "m_CreatedEvents");
			DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_m_UnhandledEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, "m_UnhandledEvents");
			DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_s_EventHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, "s_EventHandlers");
			DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_m_lastTickSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, "m_lastTickSent");
			DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_m_lastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, "m_lastFrame");
			DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_fpsAvg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, "fpsAvg");
			DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_get_PlayerConnectionGuid_Public_Static_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, 100663934);
			DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_GetGameObjectName_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, 100663935);
			DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_RegisterEventHandler_Public_Static_Boolean_Action_1_DiagnosticEvent_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, 100663936);
			DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_RegisterEventHandler_Internal_Void_Action_1_DiagnosticEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, 100663937);
			DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_UnregisterEventHandler_Public_Void_Action_1_DiagnosticEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, 100663938);
			DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_PostEvent_Public_Void_DiagnosticEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, 100663939);
			DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, 100663940);
			DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, 100663941);
			DiagnosticEventCollectorSingleton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, 100663942);
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x000139C0 File Offset: 0x00011BC0
		public unsafe static Guid PlayerConnectionGuid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1141523, RefRangeEnd = 1141525, XrefRangeStart = 1141509, XrefRangeEnd = 1141523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_get_PlayerConnectionGuid_Public_Static_get_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000139F0 File Offset: 0x00011BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141525, XrefRangeEnd = 1141527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetGameObjectName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_GetGameObjectName_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00013A34 File Offset: 0x00011C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141527, XrefRangeEnd = 1141534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref register;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref create;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_RegisterEventHandler_Public_Static_Boolean_Action_1_DiagnosticEvent_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00013A94 File Offset: 0x00011C94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1141580, RefRangeEnd = 1141583, XrefRangeStart = 1141534, XrefRangeEnd = 1141580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterEventHandler(Action<DiagnosticEvent> handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_RegisterEventHandler_Internal_Void_Action_1_DiagnosticEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00013AD8 File Offset: 0x00011CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141583, XrefRangeEnd = 1141593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterEventHandler(Action<DiagnosticEvent> handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_UnregisterEventHandler_Public_Void_Action_1_DiagnosticEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00013B1C File Offset: 0x00011D1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1141610, RefRangeEnd = 1141614, XrefRangeStart = 1141593, XrefRangeEnd = 1141610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostEvent(DiagnosticEvent diagnosticEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(diagnosticEvent));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_PostEvent_Public_Void_DiagnosticEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00013B64 File Offset: 0x00011D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141614, XrefRangeEnd = 1141631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00013B98 File Offset: 0x00011D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141631, XrefRangeEnd = 1141657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollectorSingleton.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00013BCC File Offset: 0x00011DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141657, XrefRangeEnd = 1141678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiagnosticEventCollectorSingleton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollectorSingleton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000382C File Offset: 0x00001A2C
		public DiagnosticEventCollectorSingleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00013C08 File Offset: 0x00011E08
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00003835 File Offset: 0x00001A35
		public unsafe static Guid s_editorConnectionGuid
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_s_editorConnectionGuid, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_s_editorConnectionGuid, (void*)(&value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00013C24 File Offset: 0x00011E24
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00003843 File Offset: 0x00001A43
		public unsafe Dictionary<int, DiagnosticEvent> m_CreatedEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_m_CreatedEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DiagnosticEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_m_CreatedEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00013C54 File Offset: 0x00011E54
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00003862 File Offset: 0x00001A62
		public unsafe List<DiagnosticEvent> m_UnhandledEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_m_UnhandledEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DiagnosticEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_m_UnhandledEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00013C84 File Offset: 0x00011E84
		// (set) Token: 0x060003DA RID: 986 RVA: 0x00003881 File Offset: 0x00001A81
		public unsafe DelegateList<DiagnosticEvent> s_EventHandlers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_s_EventHandlers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateList<DiagnosticEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_s_EventHandlers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00013CB4 File Offset: 0x00011EB4
		// (set) Token: 0x060003DC RID: 988 RVA: 0x000038A0 File Offset: 0x00001AA0
		public unsafe float m_lastTickSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_m_lastTickSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_m_lastTickSent)) = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00013CDC File Offset: 0x00011EDC
		// (set) Token: 0x060003DE RID: 990 RVA: 0x000038BB File Offset: 0x00001ABB
		public unsafe int m_lastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_m_lastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_m_lastFrame)) = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00013D04 File Offset: 0x00011F04
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x000038D6 File Offset: 0x00001AD6
		public unsafe float fpsAvg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_fpsAvg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticEventCollectorSingleton.NativeFieldInfoPtr_fpsAvg)) = value;
			}
		}

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr_s_editorConnectionGuid;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeFieldInfoPtr_m_CreatedEvents;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeFieldInfoPtr_m_UnhandledEvents;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeFieldInfoPtr_s_EventHandlers;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_m_lastTickSent;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_m_lastFrame;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_fpsAvg;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerConnectionGuid_Public_Static_get_Guid_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_GetGameObjectName_Protected_Virtual_String_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEventHandler_Public_Static_Boolean_Action_1_DiagnosticEvent_Boolean_Boolean_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEventHandler_Internal_Void_Action_1_DiagnosticEvent_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterEventHandler_Public_Void_Action_1_DiagnosticEvent_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_PostEvent_Public_Void_DiagnosticEvent_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200008C RID: 140
		[ObfuscatedName("UnityEngine.ResourceManagement.Diagnostics.DiagnosticEventCollectorSingleton+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060006DC RID: 1756 RVA: 0x00020038 File Offset: 0x0001E238
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DiagnosticEventCollectorSingleton.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton.__c>.NativeClassPtr);
				DiagnosticEventCollectorSingleton.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton.__c>.NativeClassPtr, "<>9");
				DiagnosticEventCollectorSingleton.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton.__c>.NativeClassPtr, "<>9__8_0");
				DiagnosticEventCollectorSingleton.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton.__c>.NativeClassPtr, "<>9__11_0");
				DiagnosticEventCollectorSingleton.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton.__c>.NativeClassPtr, 100663944);
				DiagnosticEventCollectorSingleton.__c.NativeMethodInfoPtr__RegisterEventHandler_b__8_0_Internal_Int32_DiagnosticEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton.__c>.NativeClassPtr, 100663945);
				DiagnosticEventCollectorSingleton.__c.NativeMethodInfoPtr__Awake_b__11_0_Internal_Void_DiagnosticEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton.__c>.NativeClassPtr, 100663946);
			}

			// Token: 0x060006DD RID: 1757 RVA: 0x000200DC File Offset: 0x0001E2DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiagnosticEventCollectorSingleton.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollectorSingleton.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006DE RID: 1758 RVA: 0x00020118 File Offset: 0x0001E318
			[CallerCount(0)]
			public unsafe int _RegisterEventHandler_b__8_0(DiagnosticEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(evt));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollectorSingleton.__c.NativeMethodInfoPtr__RegisterEventHandler_b__8_0_Internal_Int32_DiagnosticEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060006DF RID: 1759 RVA: 0x0002016C File Offset: 0x0001E36C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141505, XrefRangeEnd = 1141509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__11_0(DiagnosticEvent diagnosticEvent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(diagnosticEvent));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollectorSingleton.__c.NativeMethodInfoPtr__Awake_b__11_0_Internal_Void_DiagnosticEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006E0 RID: 1760 RVA: 0x00004AC9 File Offset: 0x00002CC9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000209 RID: 521
			// (get) Token: 0x060006E1 RID: 1761 RVA: 0x000201B4 File Offset: 0x0001E3B4
			// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00004AD2 File Offset: 0x00002CD2
			public unsafe static DiagnosticEventCollectorSingleton.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DiagnosticEventCollectorSingleton.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DiagnosticEventCollectorSingleton.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DiagnosticEventCollectorSingleton.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700020A RID: 522
			// (get) Token: 0x060006E3 RID: 1763 RVA: 0x000201DC File Offset: 0x0001E3DC
			// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00004AE4 File Offset: 0x00002CE4
			public unsafe static Func<DiagnosticEvent, int> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DiagnosticEventCollectorSingleton.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DiagnosticEvent, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DiagnosticEventCollectorSingleton.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700020B RID: 523
			// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00020204 File Offset: 0x0001E404
			// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00004AF6 File Offset: 0x00002CF6
			public unsafe static Action<DiagnosticEvent> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DiagnosticEventCollectorSingleton.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DiagnosticEvent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DiagnosticEventCollectorSingleton.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004DC RID: 1244
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040004DD RID: 1245
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040004DE RID: 1246
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x040004DF RID: 1247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004E0 RID: 1248
			private static readonly IntPtr NativeMethodInfoPtr__RegisterEventHandler_b__8_0_Internal_Int32_DiagnosticEvent_0;

			// Token: 0x040004E1 RID: 1249
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__11_0_Internal_Void_DiagnosticEvent_0;
		}
	}
}
