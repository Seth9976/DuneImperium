using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000149 RID: 329
	public class RuntimeInitializeOnLoadMethodAttribute : UnityEngine.Scripting.PreserveAttribute
	{
		// Token: 0x06001909 RID: 6409 RVA: 0x00075C3C File Offset: 0x00073E3C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeInitializeOnLoadMethodAttribute()
		{
			Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RuntimeInitializeOnLoadMethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr);
			RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, "m_LoadType");
			RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100666750);
			RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100666751);
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00075CA8 File Offset: 0x00073EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667014, XrefRangeEnd = 667015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loadType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x00075D58 File Offset: 0x00073F58
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x00075CF0 File Offset: 0x00073EF0
		public unsafe RuntimeInitializeLoadType loadType
		{
			get
			{
				return this.m_LoadType;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00009C33 File Offset: 0x00007E33
		public RuntimeInitializeOnLoadMethodAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x00075D30 File Offset: 0x00073F30
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x00009C3C File Offset: 0x00007E3C
		public unsafe RuntimeInitializeLoadType m_LoadType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType)) = value;
			}
		}

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadType;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0;
	}
}
