using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.ResourceManagement.Diagnostics
{
	// Token: 0x0200004C RID: 76
	public class DiagnosticEventCollector : MonoBehaviour
	{
		// Token: 0x060003E1 RID: 993 RVA: 0x00013D2C File Offset: 0x00011F2C
		// Note: this type is marked as 'beforefieldinit'.
		static DiagnosticEventCollector()
		{
			Il2CppClassPointerStore<DiagnosticEventCollector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Diagnostics", "DiagnosticEventCollector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiagnosticEventCollector>.NativeClassPtr);
			DiagnosticEventCollector.NativeFieldInfoPtr_s_Collector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticEventCollector>.NativeClassPtr, "s_Collector");
			DiagnosticEventCollector.NativeMethodInfoPtr_get_PlayerConnectionGuid_Public_Static_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollector>.NativeClassPtr, 100663947);
			DiagnosticEventCollector.NativeMethodInfoPtr_FindOrCreateGlobalInstance_Public_Static_DiagnosticEventCollector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollector>.NativeClassPtr, 100663948);
			DiagnosticEventCollector.NativeMethodInfoPtr_RegisterEventHandler_Public_Static_Boolean_Action_1_DiagnosticEvent_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollector>.NativeClassPtr, 100663949);
			DiagnosticEventCollector.NativeMethodInfoPtr_UnregisterEventHandler_Public_Void_Action_1_DiagnosticEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollector>.NativeClassPtr, 100663950);
			DiagnosticEventCollector.NativeMethodInfoPtr_PostEvent_Public_Void_DiagnosticEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollector>.NativeClassPtr, 100663951);
			DiagnosticEventCollector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticEventCollector>.NativeClassPtr, 100663952);
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00013DE8 File Offset: 0x00011FE8
		public unsafe static Guid PlayerConnectionGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141678, XrefRangeEnd = 1141679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollector.NativeMethodInfoPtr_get_PlayerConnectionGuid_Public_Static_get_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00013E18 File Offset: 0x00012018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141679, XrefRangeEnd = 1141710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DiagnosticEventCollector FindOrCreateGlobalInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollector.NativeMethodInfoPtr_FindOrCreateGlobalInstance_Public_Static_DiagnosticEventCollector_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DiagnosticEventCollector>(intPtr3) : null;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00013E4C File Offset: 0x0001204C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollector.NativeMethodInfoPtr_RegisterEventHandler_Public_Static_Boolean_Action_1_DiagnosticEvent_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00013EAC File Offset: 0x000120AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141710, XrefRangeEnd = 1141723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterEventHandler(Action<DiagnosticEvent> handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollector.NativeMethodInfoPtr_UnregisterEventHandler_Public_Void_Action_1_DiagnosticEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00013EF0 File Offset: 0x000120F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141723, XrefRangeEnd = 1141727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostEvent(DiagnosticEvent diagnosticEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(diagnosticEvent));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollector.NativeMethodInfoPtr_PostEvent_Public_Void_DiagnosticEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00013F38 File Offset: 0x00012138
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiagnosticEventCollector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiagnosticEventCollector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticEventCollector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000038F1 File Offset: 0x00001AF1
		public DiagnosticEventCollector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00013F74 File Offset: 0x00012174
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x000038FA File Offset: 0x00001AFA
		public unsafe static DiagnosticEventCollector s_Collector
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DiagnosticEventCollector.NativeFieldInfoPtr_s_Collector, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DiagnosticEventCollector>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DiagnosticEventCollector.NativeFieldInfoPtr_s_Collector, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr_s_Collector;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerConnectionGuid_Public_Static_get_Guid_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_FindOrCreateGlobalInstance_Public_Static_DiagnosticEventCollector_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEventHandler_Public_Static_Boolean_Action_1_DiagnosticEvent_Boolean_Boolean_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterEventHandler_Public_Void_Action_1_DiagnosticEvent_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_PostEvent_Public_Void_DiagnosticEvent_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
