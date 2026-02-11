using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200004E RID: 78
	public class AbstractEventData : Object
	{
		// Token: 0x06000900 RID: 2304 RVA: 0x0002A90C File Offset: 0x00028B0C
		// Note: this type is marked as 'beforefieldinit'.
		static AbstractEventData()
		{
			Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "AbstractEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr);
			AbstractEventData.NativeFieldInfoPtr_m_Used = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, "m_Used");
			AbstractEventData.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, 100664813);
			AbstractEventData.NativeMethodInfoPtr_Use_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, 100664814);
			AbstractEventData.NativeMethodInfoPtr_get_used_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, 100664815);
			AbstractEventData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, 100664816);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0002A9A0 File Offset: 0x00028BA0
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractEventData.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0002A9DC File Offset: 0x00028BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Use()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractEventData.NativeMethodInfoPtr_Use_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x0002AA18 File Offset: 0x00028C18
		public unsafe virtual bool used
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractEventData.NativeMethodInfoPtr_get_used_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0002AA60 File Offset: 0x00028C60
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbstractEventData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractEventData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000050E4 File Offset: 0x000032E4
		public AbstractEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0002AA9C File Offset: 0x00028C9C
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x000050ED File Offset: 0x000032ED
		public unsafe bool m_Used
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractEventData.NativeFieldInfoPtr_m_Used);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractEventData.NativeFieldInfoPtr_m_Used)) = value;
			}
		}

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeFieldInfoPtr_m_Used;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr_Use_Public_Virtual_New_Void_0;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr_get_used_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
