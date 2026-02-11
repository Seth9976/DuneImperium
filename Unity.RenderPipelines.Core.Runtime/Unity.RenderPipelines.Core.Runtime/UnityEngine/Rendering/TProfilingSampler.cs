using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000077 RID: 119
	public class TProfilingSampler<TEnum> : ProfilingSampler where TEnum : Enum
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x0002B24C File Offset: 0x0002944C
		// Note: this type is marked as 'beforefieldinit'.
		static TProfilingSampler()
		{
			Il2CppClassPointerStore<TProfilingSampler<TEnum>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "TProfilingSampler`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr)) })).TypeHandle.value);
			TProfilingSampler<TEnum>.NativeFieldInfoPtr_samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TProfilingSampler<TEnum>>.NativeClassPtr, "samples");
			TProfilingSampler<TEnum>.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TProfilingSampler<TEnum>>.NativeClassPtr, 100664555);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0002B2D8 File Offset: 0x000294D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964956, XrefRangeEnd = 964957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TProfilingSampler(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TProfilingSampler<TEnum>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TProfilingSampler<TEnum>.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000051B8 File Offset: 0x000033B8
		public TProfilingSampler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x0002B324 File Offset: 0x00029524
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x000051C1 File Offset: 0x000033C1
		public unsafe static Dictionary<TEnum, TProfilingSampler<TEnum>> samples
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TProfilingSampler<TEnum>.NativeFieldInfoPtr_samples, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TEnum, TProfilingSampler<TEnum>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TProfilingSampler<TEnum>.NativeFieldInfoPtr_samples, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeFieldInfoPtr_samples;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
