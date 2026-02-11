using System;
using dwd.core.input;
using dwd.core.input.click;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace leaf
{
	// Token: 0x0200001A RID: 26
	public class InstantiatePrefabOnClick : MonoBehaviour
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x00020600 File Offset: 0x0001E800
		// Note: this type is marked as 'beforefieldinit'.
		static InstantiatePrefabOnClick()
		{
			Il2CppClassPointerStore<InstantiatePrefabOnClick>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "leaf", "InstantiatePrefabOnClick");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstantiatePrefabOnClick>.NativeClassPtr);
			InstantiatePrefabOnClick.NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiatePrefabOnClick>.NativeClassPtr, "prefab");
			InstantiatePrefabOnClick.NativeFieldInfoPtr_onDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiatePrefabOnClick>.NativeClassPtr, "onDown");
			InstantiatePrefabOnClick.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiatePrefabOnClick>.NativeClassPtr, 100663464);
			InstantiatePrefabOnClick.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiatePrefabOnClick>.NativeClassPtr, 100663465);
			InstantiatePrefabOnClick.NativeMethodInfoPtr_OnClick_Private_Void_ClickedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiatePrefabOnClick>.NativeClassPtr, 100663466);
			InstantiatePrefabOnClick.NativeMethodInfoPtr_OnPressDown_Private_Void_DownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiatePrefabOnClick>.NativeClassPtr, 100663467);
			InstantiatePrefabOnClick.NativeMethodInfoPtr_Instantiate_Private_Void_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiatePrefabOnClick>.NativeClassPtr, 100663468);
			InstantiatePrefabOnClick.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiatePrefabOnClick>.NativeClassPtr, 100663469);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000206D0 File Offset: 0x0001E8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496291, XrefRangeEnd = 496311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiatePrefabOnClick.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00020704 File Offset: 0x0001E904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496311, XrefRangeEnd = 496331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiatePrefabOnClick.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00020738 File Offset: 0x0001E938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496331, XrefRangeEnd = 496372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClick(ClickedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiatePrefabOnClick.NativeMethodInfoPtr_OnClick_Private_Void_ClickedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0002077C File Offset: 0x0001E97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496372, XrefRangeEnd = 496374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPressDown(DownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiatePrefabOnClick.NativeMethodInfoPtr_OnPressDown_Private_Void_DownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000207C0 File Offset: 0x0001E9C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 496392, RefRangeEnd = 496394, XrefRangeStart = 496374, XrefRangeEnd = 496392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Instantiate(Press press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiatePrefabOnClick.NativeMethodInfoPtr_Instantiate_Private_Void_Press_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00020804 File Offset: 0x0001EA04
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstantiatePrefabOnClick()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstantiatePrefabOnClick>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiatePrefabOnClick.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002604 File Offset: 0x00000804
		public InstantiatePrefabOnClick(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00020840 File Offset: 0x0001EA40
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000260D File Offset: 0x0000080D
		public unsafe GameObject prefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiatePrefabOnClick.NativeFieldInfoPtr_prefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiatePrefabOnClick.NativeFieldInfoPtr_prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00020870 File Offset: 0x0001EA70
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000262C File Offset: 0x0000082C
		public unsafe bool onDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiatePrefabOnClick.NativeFieldInfoPtr_onDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiatePrefabOnClick.NativeFieldInfoPtr_onDown)) = value;
			}
		}

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_prefab;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_onDown;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_OnClick_Private_Void_ClickedEvent_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_OnPressDown_Private_Void_DownEvent_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Private_Void_Press_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
