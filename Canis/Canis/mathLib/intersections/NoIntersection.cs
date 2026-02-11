using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.mathLib.intersections
{
	// Token: 0x02000083 RID: 131
	[StructLayout(2)]
	public struct NoIntersection
	{
		// Token: 0x0600070D RID: 1805 RVA: 0x00036498 File Offset: 0x00034698
		// Note: this type is marked as 'beforefieldinit'.
		static NoIntersection()
		{
			Il2CppClassPointerStore<NoIntersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib.intersections", "NoIntersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoIntersection>.NativeClassPtr);
			NoIntersection.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoIntersection>.NativeClassPtr, "Instance");
			NoIntersection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoIntersection>.NativeClassPtr, 100664760);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000364F0 File Offset: 0x000346F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557100, XrefRangeEnd = 557102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoIntersection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00004AEA File Offset: 0x00002CEA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NoIntersection>.NativeClassPtr, ref this));
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0003651C File Offset: 0x0003471C
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00004AFC File Offset: 0x00002CFC
		public unsafe static NoIntersection Instance
		{
			get
			{
				NoIntersection noIntersection;
				IL2CPP.il2cpp_field_static_get_value(NoIntersection.NativeFieldInfoPtr_Instance, (void*)(&noIntersection));
				return noIntersection;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoIntersection.NativeFieldInfoPtr_Instance, (void*)(&value));
			}
		}

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
