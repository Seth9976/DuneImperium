using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002F4 RID: 756
	public class StyleSheetBuilder
	{
		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x0600349D RID: 13469 RVA: 0x0001560B File Offset: 0x0001380B
		public StyleProperty currentProperty
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x00015618 File Offset: 0x00013818
		public StyleRule BeginRule(int ruleLine)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x00015625 File Offset: 0x00013825
		public void AddSimpleSelector(Il2CppReferenceArray<StyleSelectorPart> parts, StyleSelectorRelationship previousRelationsip)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x00015632 File Offset: 0x00013832
		public void EndComplexSelector()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x0001563F File Offset: 0x0001383F
		public StyleProperty BeginProperty(string name, [Optional] int line)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x0001564C File Offset: 0x0001384C
		public void AddImport(StyleSheet.ImportStruct importStruct)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x00015659 File Offset: 0x00013859
		public void AddValue(float value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x00015666 File Offset: 0x00013866
		public void AddValue(Dimension value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x00015673 File Offset: 0x00013873
		public void AddValue(StyleValueKeyword keyword)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x00015680 File Offset: 0x00013880
		public void AddValue(StyleValueFunction function)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x0001568D File Offset: 0x0001388D
		public void AddCommaSeparator()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x0001569A File Offset: 0x0001389A
		public void AddValue(string value, StyleValueType type)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x000156A7 File Offset: 0x000138A7
		public void AddValue(Color value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x000156B4 File Offset: 0x000138B4
		public void AddValue(Object value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x000156C1 File Offset: 0x000138C1
		public void AddValue(ScalableImage value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x000156CE File Offset: 0x000138CE
		public void EndProperty()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x000156DB File Offset: 0x000138DB
		public int EndRule()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x000156E8 File Offset: 0x000138E8
		public void BuildTo(StyleSheet writeTo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x000156F5 File Offset: 0x000138F5
		public void RegisterVariable(string value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x00015702 File Offset: 0x00013902
		public void RegisterValue<T>(List<T> list, StyleValueType type, T value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x0001570F File Offset: 0x0001390F
		public static void Log(string msg)
		{
		}

		// Token: 0x02000584 RID: 1412
		public enum BuilderState
		{
			// Token: 0x04002EAC RID: 11948
			Init,
			// Token: 0x04002EAD RID: 11949
			Rule,
			// Token: 0x04002EAE RID: 11950
			ComplexSelector,
			// Token: 0x04002EAF RID: 11951
			Property
		}
	}
}
