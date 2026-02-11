using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace dwd.core.input.compositeModule.eventDispatch
{
	// Token: 0x0200009B RID: 155
	public sealed class InputButtonCompare : EqualityComparer<PointerEventData.InputButton>
	{
		// Token: 0x060006E3 RID: 1763 RVA: 0x0001D4DC File Offset: 0x0001B6DC
		// Note: this type is marked as 'beforefieldinit'.
		static InputButtonCompare()
		{
			Il2CppClassPointerStore<InputButtonCompare>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.eventDispatch", "InputButtonCompare");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputButtonCompare>.NativeClassPtr);
			InputButtonCompare.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputButtonCompare>.NativeClassPtr, "Default");
			InputButtonCompare.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputButtonCompare>.NativeClassPtr, 100664161);
			InputButtonCompare.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_InputButton_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputButtonCompare>.NativeClassPtr, 100664162);
			InputButtonCompare.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputButtonCompare>.NativeClassPtr, 100664163);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0001D55C File Offset: 0x0001B75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125708, XrefRangeEnd = 1125711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputButtonCompare()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputButtonCompare>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputButtonCompare.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0001D598 File Offset: 0x0001B798
		[CallerCount(0)]
		public unsafe override bool Equals(PointerEventData.InputButton x, PointerEventData.InputButton y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputButtonCompare.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_InputButton_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0001D5F0 File Offset: 0x0001B7F0
		[CallerCount(0)]
		public unsafe override int GetHashCode(PointerEventData.InputButton obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputButtonCompare.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00005A4E File Offset: 0x00003C4E
		public InputButtonCompare(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0001D63C File Offset: 0x0001B83C
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00005A57 File Offset: 0x00003C57
		public new unsafe static InputButtonCompare Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputButtonCompare.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputButtonCompare>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputButtonCompare.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_InputButton_InputButton_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_InputButton_0;
	}
}
